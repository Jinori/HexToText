using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HextToText
{
    public partial class MainForm : Form
    {
        TextWriter _writer = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _writer = new TextBoxStreamWriter(hexOutput);
            // Redirect the out Console stream
            Console.SetOut(_writer);
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            string hexValues = hexInput.Text;
            string[] hexValuesSplit = hexValues.Split(' ');
            foreach (String hex in hexValuesSplit)
            {
                // Convert the number expressed in base-16 to an integer. 
                int value = Convert.ToInt32(hex, 16);
                // Get the character corresponding to the integral value. 
                string stringValue = Char.ConvertFromUtf32(value);
                char charValue = (char)value;
                Console.WriteLine("hexadecimal value = {0}, int value = {1}, char value = {2} or {3}",
                                    hex, value, stringValue, charValue);
            }
        }
    }
}
