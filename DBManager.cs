using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TestAPIApp.Models;

namespace TestAPIApp.Controllers
{
    public class DBManager
    {
        //SqlConnection con = new SqlConnection();
        private static string conString = ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString;
        //public void GetConnection()
        //{
        //    string conString = ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString;
        //    con = new SqlConnection(conString);

        //    #region NoNeed
        //    //try
        //    //{
        //    //string conString = ConfigurationManager.ConnectionStrings["Connstring"].ConnectionString;
        //    //con = new SqlConnection(conString);
        //    //con.Open();
        //    //}
        //    //catch(Exception e)
        //    //{
        //    //}
        //    //finally
        //    //{
        //    //    con.Close();
        //    //}
        //    #endregion
        //}

        public List<State> GetStates(string CountryID)
        {
            List<State> sList = new List<State>();            
            SqlConnection con = new SqlConnection();
            try
            {
                using (con = new SqlConnection(conString))
                {
                    string query = "SELECT StateID,StateName from States where CountryID=" + CountryID;
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                State c = new State { StateID = Convert.ToInt32(reader["StateID"]), StateName = reader["StateName"].ToString() };
                                sList.Add(c);
                            }
                        }
                    }
                }
                return sList;
            }
            catch(Exception)
            {
                return null;
            }
            finally
            {
                if (con != null)
                { con.Close(); }
            }
        }


        public List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();
            SqlConnection con = new SqlConnection();
            try
            {
                using (con = new SqlConnection(conString))
                {
                    string query = "SELECT CountryID, CountryName FROM Countries";
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Country c = new Country { CountryID = Convert.ToInt32(reader["CountryID"]), CountryName = reader["CountryName"].ToString() };
                                countries.Add(c);
                            }
                        }
                    }
                }
                return countries;
            }
            catch(Exception)
            {
                return null;
            }
            finally
            {
                if (con != null)
                { con.Close(); }
            }
        }

        public bool ValidateLogin(string username, string password)
        {
            SqlConnection con = new SqlConnection();
            try
            {                
                using (con = new SqlConnection(conString))
                {
                    string query = "SELECT Count(*) As cnt FROM EmployeeLogin WHERE Username='" + username + "' AND Password='" + password + "'";
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = con;
                        con.Open();

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                            return true;   
                    }
                }
            }
            catch(Exception)
            {                
            }
            finally
            {
                if (con != null)
                { con.Close(); }
            }
            return false;
        }
    }
}