using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA_199.Classes
{
    class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string RegNo { get; set; }
        public Student(int id, string firstName, string LastName, string RegNo)
        {
            this.id = id;
            this.firstName = firstName;
            this.LastName = LastName;
            this.RegNo = RegNo;
        }
        public static bool Contains(List<Student> list, int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                    return true;
            }
            return false;
        }
        
    }
}
