using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Name
    {
        private string name;


        public string Names
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        public Name(string n) 
        {
            Names = n;

        }

    }
}
