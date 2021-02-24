using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class_B:Class_A
    {
        private double k;
        public double K
        {
            get
            {
                return k;
            }
            set
            {
                 k = value;
              
            }
        }


      

        public override double Formula1(double a, double n)
        {

            A = a;
            K = n;
           

            if (K == 0) return 1;
            else if (K == 1) return A;
            return A < 0 ? 1 / Formula1(A, K) : K % 2 == 0 ?
                Formula1(A * A, K / 2) : A * Formula1(A * A, (K - 1) / 2);


        }
                              

        public override double Formula2(double a, double n)
        {
            

            A = a;
            K = n;
            double x = 1;
            for (int i = 0; i < 1000; i++)
                if (x == (x = 1.0 / K * (((K - 1) * x) + (A / Math.Pow(x, K-1 )))))//
                    break;
            return x;


        }
    }
}

