using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_Lab.COMP
{
    /**
     * Factory interface.
     * 
     * Version 1.0, Feb 13 2025
     * */
    public interface ModulesFactoryIF
    {
        double CurrentVal { get; set; }
        ModulesIF CreateModule(string name);
    }
}
