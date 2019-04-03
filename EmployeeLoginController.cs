//using DBAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
//using DBAccess;
using TestAPIApp.Models;

namespace TestAPIApp.Controllers
{
    public class EmployeeLoginController : ApiController
    {
        [System.Web.Http.HttpGet, System.Web.Http.Route("api/Login")]
        public bool GetValidaate(string username,string password)
        {
            #region anotherwayForConnectionEstablishment
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString =
            //"Data Source=DESKTOP-EM068UD;" +
            //"Initial Catalog=MyDB;" +
            //"Integrated Security=SSPI;";
            //conn.Open();
            #endregion

            DBManager db = new DBManager();
            return db.ValidateLogin(username, password);

            #region oldStuff

            //string constr = ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    string query = "SELECT Count(*) As cnt FROM EmployeeLogin WHERE Username='"+username+"' AND Password='"+password+"'";                
            //    using (SqlCommand cmd = new SqlCommand(query))
            //    {
            //        cmd.Connection = con;
            //        cmd.CommandType = System.Data.CommandType.Text;
            //        con.Open();                  

            //        int count = Convert.ToInt32(cmd.ExecuteScalar());
            //        con.Close();
            //        if (count > 0)
            //            return true;
            //        else
            //            return false;                   
            //    }
            //}           
            #endregion
        }
        [System.Web.Http.HttpGet, System.Web.Http.Route("api/GetCountries")]
        public List<Country> GetCountries()
        {
            try
            {
                DBManager db = new DBManager();
                List<Country> countries = new List<Country>();
                return countries = db.GetCountries();
            }
            catch
            {   throw;  }

            #region oldStuff
            //string constr = ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    string query = "SELECT CountryID, CountryName FROM Countries";
            //    using (SqlCommand cmd = new SqlCommand(query))
            //    {
            //        cmd.Connection = con;                   
            //        con.Open();
            //        SqlDataReader reader = cmd.ExecuteReader();                    
            //        while (reader.Read())
            //        {
            //            Country c = new Country { CountryID = Convert.ToInt32(reader["CountryID"]), CountryName = reader["CountryName"].ToString() };
            //            countries.Add(c);
            //        }
            //    }
            //    return countries;
            //}
            #endregion
        }

        [System.Web.Http.HttpGet, System.Web.Http.Route("api/GetStates")]
        public List<State> GetStateByCountry(string CountryID)
        {
            try
            {
                List<State> States = new List<State>();
                DBManager db = new DBManager();
                var returnList = db.GetStates(CountryID);
                if (returnList != null)
                {
                    States = returnList;
                }
                return States;
            }
            catch(Exception)
            { return null; }

            #region oldStuff
            //string constr = ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    string query = "SELECT StateID,StateName from States where CountryID="+ CountryID;
            //    using (SqlCommand cmd = new SqlCommand(query))
            //    {
            //        cmd.Connection = con;                    
            //        con.Open();
            //        SqlDataReader reader = cmd.ExecuteReader();                    
            //        while (reader.Read())
            //        {
            //            State s = new State { StateID = Convert.ToInt32(reader["StateID"]), StateName = reader["StateName"].ToString() };
            //            States.Add(s);
            //        }
            //    }
            //    return States;
            //}
            #endregion
        }

        //[System.Web.Http.HttpGet, System.Web.Http.Route("api/GetLogins")]
        //public bool GetLogins(string username, string password)
        //{
        //    using (SampleDBEntities ent = new SampleDBEntities())
        //    {
        //        return Validate(username, password);
        //    }
        //}

        //// [HttpGet]
        //public bool Validate(string username, string password)
        //{
        //    bool IsAvaiable = false;
        //    using (SampleDBEntities ent = new SampleDBEntities())
        //    {
        //        IsAvaiable = ent.EmployeeLogins.Where(e => e.UserName.Equals(username) && e.Password.Equals(password)).Any();
        //    }
        //    return IsAvaiable;
        //}
    }
}
