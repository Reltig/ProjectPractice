using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractice
{
    internal class DTOHistory
    {
        public string date { get; set; }
        public string name { get; set; }
        public int accuracy { get; set; }
        public int density { get; set; }
        public int mode { get; set; }

        public override string ToString()
        {
            return $"{date} - {name}";
        }
    }
}
