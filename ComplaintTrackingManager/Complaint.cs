using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Complaint
    {

        public string monthname { get; set; }
        public int c1 { get; set; }

        public int c2 { get; set; }
        public int c3 { get; set; }

        public int c4 { get; set; }

        public int c5 { get; set; }



        public Complaint(String monthname, int c1, int c2, int c3, int c4, int c5)
        {
            this.monthname = monthname;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
            this.c4 = c4;
            this.c5 = c5;
        }
    }
}
