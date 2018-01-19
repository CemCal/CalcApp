using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{

    public delegate double DG_Operation(double p1, double p2);

    public static class Operations
    {

        public static double Add(double p1, double p2)
        {
            return p1 + p2;
        }

        public static double Subtract(double p1, double p2)
        {
            return p1 - p2;
        
        }

        public static double Multiply(double p1, double p2)
        {
            return p1 * p2; 
        }

        public static double Divide(double p1, double p2)
        {
            return p1 / p2;
        }

    }

    
}
