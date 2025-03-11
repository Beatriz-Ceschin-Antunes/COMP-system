using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M5_Lab.COMP;
using M5_Lab.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace M5_Lab
{
    /**
     * Class used for GUI elements.
     * 
     * Version 1.0, Feb 13 2025
     * */
    public partial class Form1 : Form
    {
        private ModulesFactoryIF factory = new ModulesFactory();
        
        // Initialize the GUI.
        public Form1()
        {
            InitializeComponent();
            PopulateList();
            textBox1.Text = "0";
        }

        // Pull modules list from text file and display in ListBox.
        public void PopulateList()
        {
            // Path to the .txt file
            string filePath = "..\\..\\Resources\\modules.txt";

            // Check if the file exists.
            if (File.Exists(filePath))
            {
                // Read all lines from the text file.
                string[] lines = File.ReadAllLines(filePath);

                // Clear existing items in the ListBox.
                Modules.Items.Clear();

                // Add each line from the text file to the ListBox.
                foreach (string line in lines)
                {
                    Modules.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }
        }

        // Sets up and displays an InputBox to ask for user input.
        public static string Popup()
        {
            string message, title;
            object inputBox;

            message = "Please enter value for calculation.";

            title = "User Input Requested";

            inputBox = Interaction.InputBox(message, title);

            // Return user input if not empty.
            if ((string)inputBox != null && (string)inputBox != "")
            {
                return (string)inputBox;
            }
            else
            {
                DialogResult warning = new DialogResult();
                warning = MessageBox.Show("Please enter a number.");
                if (warning != DialogResult.Yes)
                {
                    return Popup();
                }
            }
            
            return " "; // error
        }

        // Triggers NewModule when a module is selected from the ListBox.
        private void Modules_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModule = Modules.SelectedItem.ToString();

            // Create new module.
            NewModule(selectedModule);
        }

        // Delegate to factory for selected module to be created.
        private void NewModule(string module)
        {
            // Create new module.
            ModulesIF newModule = factory.CreateModule(module);

            // Update current value.
            factory.CurrentVal = newModule.calculate();

            // Update GUI text box for current value.
            textBox1.Text = factory.CurrentVal.ToString();
        }
    }
}
