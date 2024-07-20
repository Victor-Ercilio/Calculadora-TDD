using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculator
    {
        public Calculator()
        {

        }
        
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Divide(double dividend, double divisor)
        {
            if(divisor == 0)
                throw new DivideByZeroException();
            return dividend / divisor;
        }

        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }
    }
}
