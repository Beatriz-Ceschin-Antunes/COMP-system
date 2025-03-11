using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_Lab.COMP
{
    /**
     * Abstract class that implements ModulesIF and keeps current value.
     * 
     * Version 1.0, Feb 13 2025
     * */
    public abstract class Modules : ModulesIF
    {
        public double currentValue = 0;
        public double Value 
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = value;
            }
        }

        public abstract double calculate();
    }
}
