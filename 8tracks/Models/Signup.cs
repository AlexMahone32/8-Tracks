using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace _8tracks.Models
{
    public class Signup
    {
        public bool varification(string uname)
        {
            string conn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Damon Salvatore\Desktop\8tracks_2014-06-07 18-16-42Z\8tracks\App_Data\Database1.mdf;Integrated Security=True";
            SqlConnection c = new SqlConnection(conn);
            c.Open();
            string q = "select * from [User] where name = '" + uname + "'";
            SqlCommand cmd = new SqlCommand(q, c);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}