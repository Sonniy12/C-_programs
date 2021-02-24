using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Last_name
    {

        private string l_name;
        

        public string L_Name
        {
            get
            {
                return l_name;
            }
            private set
            {
                l_name =  value;
            }
        }

        public Last_name(string L_n) 
        {
            L_Name = L_n;
          
        }

        


    }
}
