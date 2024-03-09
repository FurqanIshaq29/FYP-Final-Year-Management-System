using ProjectA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA_199.Students
{
    public static class Student
    {
        public static void addStudent(int id,string regNo)
        {
            var con = Configuration.getInstance().getConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into Table_1 values (@Id, @RegistrationNo)", con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Name", regNo);

            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
