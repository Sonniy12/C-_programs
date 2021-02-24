using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp28
{
    class JerseyNumber
    {
        
        public string Player { get; private set; }
        public int YearRetired { get; private set; }

        public JerseyNumber(string name, int year)
        {
            Player = name;
            YearRetired = year;
        }

    }


}
