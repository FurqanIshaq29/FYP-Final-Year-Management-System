using ProjectA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA_199.Classes
{
    class Student_H
    {
        public static void addStudent(int id, string reg)
        {
            var con = Configuration.getInstance().getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Student values(@id,@regno)", con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("regno", reg);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
        }
        public static DataTable GetStudentTable()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from student", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public static DataTable GetStudentTableDetails()
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("Select p.id,p.FirstName,p.LastName,s.RegistrationNo,p.Contact,p.Email,p.DateOfBirth,l.Value as Gender " +
                "from student as s " +
                "join person as p on s.id = p.id " +
                "join lookup as l on p.gender = l.id", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public static void updateStu(string regNo, int PID)
        {
            string Text = "UPDATE Student SET RegistrationNo = @Regno_ Where id = @id_";
            var con = Configuration.getInstance().getConnection();

            con.Open();
            SqlCommand cmd = new SqlCommand(Text, con);
            cmd.Parameters.AddWithValue("Regno_", regNo);
            cmd.Parameters.AddWithValue("id_", PID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
        }
        public static DataTable Search(string str = "")
        {
            var con = Configuration.getInstance().getConnection();

            con.Open();
            using (DataTable dt = new DataTable("Person"))
            {
                using (SqlCommand cmd = new SqlCommand("Select p.id,p.FirstName,p.LastName,s.RegistrationNo,p.Contact,p.Email,p.DateOfBirth,l.Value as Gender " +
                    "from student as s " +
                    "join person as p on s.id = p.id " +
                    "join lookup as l on p.gender = l.id " +
                    "where FirstName + LastName + RegistrationNo + Email + l.value + contact like @str ", con))
                {
                    cmd.Parameters.AddWithValue("str", string.Format("%{0}%", str));
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                return dt;
            }
        }
    }
}
