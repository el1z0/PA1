using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Student
    {
        public string Group { get; set; }
        public int YearAdmission { get; set; }
        public string FIO { get; set; }
        public List<Mark> Marks {get;set;}
    }
}
