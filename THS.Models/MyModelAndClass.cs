using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHS.Models
{
    public class MyModelAndClass
    {
        public MyModelAndClass() { }
        public string username { get; set; }
        public string pass { get; set; }
        public string newpass { get; set; }
        public MyModelAndClass(string Username, string Pass, string Newpass)
        {
            username = Username; pass = Pass; newpass = Newpass;
        }


    }
}
