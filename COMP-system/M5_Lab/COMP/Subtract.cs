using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_Lab.COMP
{
    /**
     * Subtracts current value by user input.
     * 
     * Version 1.0, Feb 13 2025
     * */
    internal class Subtract : InputMods
    {
        public override double calculate()
        {
            return Value - userInput;
        }
    }
}
