using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Class_A
    {
        private double a, n;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double N
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }
        public virtual double Formula1(double a, double n)
        {
         
            A = a;
            N = n;
            if (A != 0 && N != 0)
            {

                return A * Formula1(A, N- 1);
            }
            else
            {
                return 1;
            }


        }
        public virtual double Formula2(double a, double n)
        {
            this.A = a;
            this.N = n;
            
            if ((A * 10000) - (N * N) <= 0)
            { 
                return N/100;
            }
            else
            {return  Formula2(A, N + 1); }
                
        }
    }
}
