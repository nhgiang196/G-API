
using THS.WebAPI.Helper;
using log4net;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
using EHS.Models;
using System.Data.SqlClient;

namespace THS.WebAPI.Controller
{
    [THS.WebAPI.Filter.FilterIP]
    [RoutePrefix("api/thiscontroller")]
    public class THSAdminController : ApiController
    {

        OperationResult operationResult = new OperationResult();
        thsContext _context = new thsContext();
        HelperBiz _helper = new HelperBiz();

        

        public class gvuser
        {
            public gvuser() { }
            public string username { get; set; }
            public string pass { get; set; }
            public string newpass { get; set; }
            public gvuser(string Username, string Pass, string Newpass)
            {
                username = Username; pass = Pass; newpass = Newpass;
            }
        }

        [Route("ChangePassword")]
        [HttpPost]
        public IHttpActionResult ChangePassword(gvuser pr)
        {
            try
            {
                var dt = _context.ChangePassword(pr.username, pr.pass, pr.newpass).ToList();
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Loger.Error(e);
                throw new Exception(e.Message);
            }
            return Ok(operationResult);
        }


    }
}
