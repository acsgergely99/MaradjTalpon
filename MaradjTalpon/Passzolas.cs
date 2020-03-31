using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaradjTalpon
{
    class Passzolas
    {
        public static string passzolasiLehetoseg;

        public string PasszolasiLehetoseg { get => passzolasiLehetoseg; set => passzolasiLehetoseg = value; }

        public Passzolas(string passzolasiLehetoseg)
        {
            this.PasszolasiLehetoseg = passzolasiLehetoseg;
        }        
    }
}
