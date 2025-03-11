using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M5_Lab.COMP
{
    /**
     * Asbtract class for modules that ask for user input.
     * 
     * Version 1.0, Feb 13 2025
     * */
    public abstract class InputMods : Modules
    {
        public double userInput { get; set; }
        
        // Constructor triggers popup window to ask for input.
        public InputMods()
        {
            requestInput();
        }

        // Update value for user input.
        public void requestInput()
        {
            string inputPopup = Form1.Popup();
            this.userInput = double.Parse(inputPopup);
        }
    }
}
