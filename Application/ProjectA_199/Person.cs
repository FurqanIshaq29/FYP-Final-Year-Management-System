using ProjectA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA_199.Persons
{
    public static class Person
    {
        public static void addPerson(string firstName,string lastName,string contact,string email,DateTime dob,int gender)
        {
            var con = Configuration.getInstance().getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Person values(@FirstName, @LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Contact", contact);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@DateOfBirth", dob);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully saved");


        }

        //return the last person person id so that it will help in updating and adding new students
        public static int getlastPersonId()
        {
            string insertsq = "Select Max(Id) as LastID from Person";
            var con = Configuration.getInstance().getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(insertsq, con);
            int answer = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return answer;



        }
    }
}
