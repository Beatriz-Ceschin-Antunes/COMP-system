using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_Lab.COMP
{
    /**
     * Adds user input to current value.
     * 
     * Version 1.0, Feb 13 2025
     * */
    public class Sum : InputMods
    {
        public override double calculate()
        {
            return Value + userInput;
        }
    }
}
