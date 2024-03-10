using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project.Bl
{
    class Advisor
    {
        public string fname;
        public string lname;
        public int id;
        public Advisor(string fname,string lname,int id)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
        }
        public Advisor()
        {

        }

    }
}
