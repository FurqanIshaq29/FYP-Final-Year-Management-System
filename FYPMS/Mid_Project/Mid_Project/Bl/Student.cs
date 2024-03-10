using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project.Bl
{
    class Student
    {
        public string first_name;
        public string last_name;
        public string registration_no;
        public int id;
        public string contact;
        public string email;
        public int gender;
        public Student()
        {

        }
        public Student(string fname,string lname,string regno,int Id,string contact,string email,int gender)
        {
            this.first_name = fname;
            this.last_name = lname;
            this.registration_no = regno;
            this.id = Id;
            this.contact = contact;
            this.email = email;
            this.gender = gender;
        }
    }
}
