using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED_AP2
{
    class Projects:Student
    {
        public string projectName { get; set; }
        public DateTime daySent { get; set; }
        public DateTime dayLimit { get; set; }
        public int grade { get; set; }
        public bool lateSent { get; set; }
    }
}
