using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace THS.WebAPI.Filter
{
    public class FilterIPAttribute : AuthorizationFilterAttribute
    {
        protected readonly ILog log = LogManager.GetLogger("HSSELogger");
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //[0] = {[MS_OwinContext, Microsoft.Owin.OwinContext]}

            var context = actionContext.Request.Properties["MS_OwinContext"] as Microsoft.Owin.OwinContext;
            Console.WriteLine(context.Request.RemoteIpAddress);//请求的IP
            Console.WriteLine(context.Request.LocalIpAddress); //服务的IP

            string userIP = context.Request.RemoteIpAddress;
            var allowedIP = ConfigurationManager.AppSettings["AllowedIPList"];
            if (allowedIP == "*")
            {
                base.OnAuthorization(actionContext);
            }
            else
            {
                var allowedIPList = allowedIP.Split(',');
                try
                {
                    allowedIPList.AsQueryable().First(x => x == userIP);
                }
                catch (Exception)
                {
                    actionContext.Response =
                       new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden)
                       {
                           Content = new StringContent("Unauthorized IP Address")
                       };
                    log.Info(string.Format("Unauthorized IP Address：{0}", userIP));
                    return;
                }
            }

        }

    }
}