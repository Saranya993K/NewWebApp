using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DBAccess;

namespace TestAPIApp.Controllers
{
    public class EmployeeLoginController : ApiController
    {
        [HttpGet]
        public bool GetLogins(string username,string password)
        {
            using (SampleDBEntities ent = new SampleDBEntities())
            {
                return Validate(username, password);
            }
        }

       // [HttpGet]
        public bool Validate(string username, string password)
        {
            bool IsAvaiable = false;
            using (SampleDBEntities ent = new SampleDBEntities())
            {
                IsAvaiable = ent.EmployeeLogins.Where(e => e.UserName.Equals(username) && e.Password.Equals(password)).Any();   
            }
            return IsAvaiable;
        }
    }
}
