using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toycar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Compile_Click(object sender, EventArgs e)
        {
            // Initial and final states
            String Initial_State = "S0";
            String Final_State = "S3";
            var dict = new Dictionary<string, Dictionary<string, string>>();

            // Define state transitions based on the command grammar
            dict.Add("S0", new Dictionary<string, string>()
            {
                { "Start", "S1" },
                { "Stop", "S1" },
                { "Accelerate", "S1" },
                { "Brake", "S1" },
                { "Right", "S1" }
            });

            dict.Add("S1", new Dictionary<string, string>()
            {
                { "Right", "S2" },
                { "Start Right", "S2" },
                { "Stop Right", "S2" },
                { "Accelerate Right", "S2" },
                { "Brake Right", "S2" }
            });

            dict.Add("S2", new Dictionary<string, string>()
            {
                { "Right", "S2" },
                { "Start Right", "S2" },
                { "Stop Right", "S2" },
                { "Accelerate Right", "S2" },
                { "Brake Right", "S2" },
                { "Right Right", "S3" }
            });

            dict.Add("S3", new Dictionary<string, string>()
            {
                { "Right", "S3" },
                { "Start Right", "S3" },
                { "Stop Right", "S3" },
                { "Accelerate Right", "S3" },
                { "Brake Right", "S3" },
                { "Right Right", "S3" }
            });

            string strinput = Input.Text; // Get input from a TextBox named Input
            string[] commands = strinput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string state = Initial_State;

            // Process each command
            foreach (string command in commands)
            {
                if (dict.ContainsKey(state) && dict[state].ContainsKey(command))
                {
                    state = dict[state][command]; // Move to the next state based on command
                }
                else
                {
                    state = "Se"; // Error state
                    break;
                }
            }

            // Check if the final state is reached or if the last state is S1 or S2
            if (state.Equals(Final_State) || state.Equals("S2") || state.Equals("S1"))
            {
                Output.Text = "RESULT OKAY"; // Output TextBox for result
            }
            else
            {
                Output.Text = "ERROR"; // Output TextBox for error message
            }
        }
    }
   }