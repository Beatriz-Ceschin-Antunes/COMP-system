using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_Lab.COMP
{
    /**
     * Calculates exponentiation with user input exponent.
     * 
     * Version 1.0, Feb 13 2025
     * */
    internal class Power : InputMods
    {
        public override double calculate()
        {
            return Math.Pow(Value, userInput);
        }
    }
}
