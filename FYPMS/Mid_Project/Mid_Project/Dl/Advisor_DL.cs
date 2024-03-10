using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mid_Project.Bl;
using System.Data.SqlClient;

namespace Mid_Project.Dl
{
    class Advisor_DL
    {
       public static  List<Advisor> advisor_data = new List<Advisor>();
       public static void add_tolist()
        {
            var con = Configuration.getInstance().getConnection();
            
            string query = "Select A.Id,P.FirstName,P.LastName From Advisor A Join Person P On A.Id = P.Id";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                int id = reader.GetInt32(0);
                string fname = reader.GetString(1);
                string lname = reader.GetString(2);
                Advisor a = new Advisor(fname,lname,id);
                advisor_data.Add(a);
            }
            reader.Close();
        }
        
    }
}
