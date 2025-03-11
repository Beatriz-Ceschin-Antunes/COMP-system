using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace M5_Lab.COMP
{
    /**
     * Initializes current value with user input.
     * 
     * Version 1.0, Feb 13 2025
     * */
    public class Initialize : InputMods
    {
        public override double calculate()
        {
            Value = userInput;
            return Value;
        }
    }
}
