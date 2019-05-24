
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
using System.Configuration;
using NBear.Data;

namespace THS.WebAPI.Controller
{
    [RoutePrefix("api/thiscontroller")]
    public class ThisController : ApiController
    {
        thsContext _context = new thsContext();
        public db_TestEntities db = new db_TestEntities();
        public Gateway mygate = new Gateway(0,new db_TestEntities().Database.Connection.ConnectionString);
        [Route("Myfunction")]
        [HttpGet]
        public IHttpActionResult Myfunction()
        {
            try
            {
                var dt = mygate.ExecuteStoredProcedure("GetData", new string[] { }, new object[] { });
                Dictionary<string, object> result = new Dictionary<string, object>();
                result.Add("Table1", dt.Tables[0]);
                result.Add("Table2", dt.Tables[1]);
                return Ok(dt);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
                throw new Exception(e.Message);
            }
            

        }

    }
}
