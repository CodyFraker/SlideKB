using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SliderConsole
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames(); // Gets port names of all used ports

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port); // Adds all port names to the dropdown menu
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int item = comboBox1.SelectedIndex; // Takes the selected item from the dropdown menu
            if (item == -1) // Occurs when a user is fails to select a proper COM port.
            {
                MessageBox.Show("Please select a COM port occupied by the slider!");
            }
            else
            {
                Slider slider1 = new Slider();
                slider1.portName = comboBox1.Items[item].ToString(); // Sets port name from dropdown

                if (Baud115Radio.Checked == true)
                {
                    slider1.baudRate = 115200;
                }
                else if (Baud9600Radio.Checked == true)
                {
                    slider1.baudRate = 9600;
                }
                else
                {
                    MessageBox.Show("Please select a baud rate!");
                }
                try
                {
                    slider1.initialize();
                    Form1 form1 = new Form1(slider1);
                    this.Hide(); // Close this window for now
                    form1.Show();
                }
                catch (Exception e1)
                {


                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); // Gets port names of all used ports

            for(int i=0; i <= comboBox1.Items.Count; i++)
            {
                comboBox1.Items.RemoveAt(0);
            }
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port); // Adds all port names to the dropdown menu
            }
            comboBox1.SelectedItem = null;
            comboBox1.SelectedText = string.Empty;
        }
    }
}
