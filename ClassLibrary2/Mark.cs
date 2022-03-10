using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Mark
    {
        public DateTime date { get; set; }
        public string Estimation { get; set; }

        public List<string> Estimations => new List<string>()
        {
            "2",
            "3",
            "4",
            "5",
            "н",
            "п",
            "б",
            "у"
        };
    }
}
