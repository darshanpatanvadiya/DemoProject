using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using ProjectDemo.Models;

namespace ProjectDemo.Repository
{
    public class UserRepository
    {
        public SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["connectionStrings"].ToString();
            con = new SqlConnection(constr);
        }
         
        public List<Users> GetAllUserList()
        {
            List<Users> Userlist = new List<Users>();
            try
            {
                connection();
                con.Open();
                Userlist = SqlMapper.Query<Users>(con, "SP_allUserList").ToList();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Userlist;
        }
    }
}