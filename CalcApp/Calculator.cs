using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    public class Calculator
    {
        public double Calculate(double p1, double p2, DG_Operation operation)
        {
            return operation(p1, p2);

        }
    }
}
