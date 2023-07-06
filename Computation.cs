using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_CSharp
{
    public static class Computation
    {
        /// <summary>
        /// Divide two integer numbers : a dividend and a divisor, then return the result.
        /// </summary>
        /// <param name="dividend">Dividend of the division</param>
        /// <param name="divisor">Divisor of the division</param>
        /// <returns>Quotient of the division</returns>
        public static float GetDivision(int dividend, int divisor)
        {
            return dividend / (float)divisor;
            // Note: Convert divisor as float to avoid getting a rounded integer
        }
    }
}
