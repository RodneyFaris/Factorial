using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    public class Factorial
    {
        public int Calculate(int value)
        {
            double F(double fact)
            {
                value -= 1;
                if (value <= 1) return fact;
                
                return fact * F(value);
            }
            var result = F(value);
            return result >= int.MaxValue ? -1 : (int)result;
        }
    }
}
