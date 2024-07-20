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
        
        /// <summary>
        /// It gets two double precision numbers and returns the sum of them
        /// </summary>
        /// <param name="value1">First number</param>
        /// <param name="value2">Second number</param>
        /// <returns>Sum of the numbers if it's possible</returns>
        /// <exception cref="ArithmeticException">
        /// If the sum of the values exceeds the maximum or minimum double values
        /// </exception>
        public double Add(double value1, double value2)
        {
            if(value1 > 0 && value2 > 0 && 
                (double.MaxValue - value1) < value2)
                throw new ArithmeticException("Exceeds double maximum value");
            if(value1 < 0 && value2 < 0 && 
                (double.MinValue - 1) < value2)
                throw new ArithmeticException("Exceeds double minimum value");
            return value1 + value2;
        }

        /// <summary>
        /// Gets two numbers and return, if possible, the division between them
        /// </summary>
        /// <param name="dividend">The number to be divided</param>
        /// <param name="divisor">The number that says in how many parts to divided</param>
        /// <returns>A number that is one part of the total</returns>
        /// <exception cref="DivideByZeroException"></exception>
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

        public double Sub(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }
    }
}
