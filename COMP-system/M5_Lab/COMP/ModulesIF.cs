using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_Lab.COMP
{
    /**
     * Modules interface.
     * 
     * Version 1.0, Feb 13 2025
     * */
    public interface ModulesIF
    {
        double Value { get; set; }
        double calculate();
    }
}
