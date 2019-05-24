
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
    [RoutePrefix("api/thiscontroller")]
    public class THSAdminController : ApiController
    {
        thsContext _context = new thsContext();

        [Route("Myfunction")]
        [HttpGet]
        public IHttpActionResult Myfunction(MyModelAndClass pr)
        {
            try
            {
                var dt = _context.ChangePassword(pr.username, pr.pass, pr.newpass).ToList();
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return Ok();
        }

    }
}
