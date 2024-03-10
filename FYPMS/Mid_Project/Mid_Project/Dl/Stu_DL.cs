using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mid_Project.Bl;

namespace Mid_Project.Dl
{
     class Stu_DL
    {
        public static List<Student> stu_list = new List<Student>();
         public static bool  check(int id)
        {
            for(int x  = 0; x < stu_list.Count; x++)
            {
                if(id == stu_list[x].id)
                {
                    return false;
                }
            }
            return true;
             
        }
    }
}
