using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp45
{
    class Human
    {
        public string Name { get; private set; }
        public string LName { get; private set; }
        public string Email { get; private set; }

        public Human(string n, string ln, string em)
        {
            Name = n;
            LName = ln;
            Email = em;

        }

    }
}
