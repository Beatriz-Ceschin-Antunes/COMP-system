using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_Lab.COMP
{
    /**
     * Calculates log of current number.
     * 
     * Version 1.0, Feb 13 2025
     * */
    public class Log : NoInputMods
    {
        public override double calculate()
        {
            return Math.Log(Value);
        }
    }
}
