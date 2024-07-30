using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculator
    {

        /// <summary>
        /// It gets two double precision numbers and returns the sum of them
        /// </summary>
        /// <param name="value1">First number</param>
        /// <param name="value2">Second number</param>
        /// <returns>Sum of the numbers if it's possible</returns>
        /// <exception cref="ArithmeticException">
        /// If the sum of the values exceeds the maximum or minimum double values
        /// </exception>
        public static double Add(double value1, double value2)
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
        /// It gets two numbers and return, if possible, the division between them
        /// </summary>
        /// <param name="dividend">The number to be divided</param>
        /// <param name="divisor">The number that says in how many parts to divided</param>
        /// <returns>A number that is one part of the total</returns>
        /// <exception cref="DivideByZeroException"></exception>
        public static double Divide(double dividend, double divisor)
        {
            if(divisor == 0)
                throw new DivideByZeroException();
            return dividend / divisor;
        }

        /// <summary>
        /// It gets two numbers and return the multiplication of them
        /// </summary>
        /// <param name="value1">The first number</param>
        /// <param name="value2">The second number</param>
        /// <returns>The multiplication of the two numbers</returns>
        public static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        /// <summary>
        /// It gets two numbers and return the subtraction of
        /// the first by the second
        /// <summary>
        /// <param name="minuend">The number to be diminshed</param>
        /// <param name="subtrahend">The number that is subtract</param>
        /// <returns>Subtraction of the minuend by the subtrahend</returns>
        public static double Sub(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }
    }
}
