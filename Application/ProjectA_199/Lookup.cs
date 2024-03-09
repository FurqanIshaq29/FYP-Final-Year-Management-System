using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA;

namespace ProjectA_199.Lookups
{
    public static class Lookup
    {
        //public static int getGenders()
        //{
        //    //var con = Configuration.getInstance().getConnection();

        //    //SqlCommand cmd = new SqlCommand("Select value from Lookup where Category = 'Gender'", con);
        //    //SqlDataReader sdr = cmd.ExecuteReader();
        //    //List<string> list = new List<string>();
        //    //while (sdr.Read())
        //    //{
        //    //    string gender = sdr.GetString(0);
        //    //    list.Add(gender);
        //    //}
        //    //return list;
        //    if (gender_cbox.Text == "Male")
        //    {
        //        return 1;
        //    }
        //    if (gender_cbox.Text == "Female")
        //    {
        //        return 2;
        //    }
        //}

        public static int getIndexFromValue(string str)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand($"Select Id from Lookup where value = '{str}'", con);
            con.Open();
            int id = (int)cmd.ExecuteScalar();
            con.Close();
            return id;
        }
    }
}
