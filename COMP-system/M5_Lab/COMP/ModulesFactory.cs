using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_Lab.COMP
{
    /**
     * Creates modules.
     * 
     * Version 1.0, Feb 13 2025
     * */
    public class ModulesFactory : ModulesFactoryIF
    {
        public double currentVal = 0;

        // Return current value.
        double ModulesFactoryIF.CurrentVal
        {
            get { return currentVal; }
            set { currentVal = value; }
        }
        
        // Create and return modules on demand.
        public ModulesIF CreateModule(string name)
        {
            Type t = Type.GetType("M5_Lab.COMP." + name);
            Object o = Activator.CreateInstance(t);
            ModulesIF module = o as ModulesIF;
            module.Value = currentVal;
            return module;
        }
    }
}
