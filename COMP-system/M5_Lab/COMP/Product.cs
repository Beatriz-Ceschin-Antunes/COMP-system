using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_Lab.COMP
{
    /**
     * Multiplies user input by current value in the system.
     * 
     * Version 1.0, Feb 13 2025
     * */
    internal class Product : InputMods
    {
        public override double calculate()
        {
            return Value * userInput;
        }
    }
}
