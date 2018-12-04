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
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int item = comboBox1.SelectedIndex;
            if (item == -1) // Occurs when a user is fails to select a proper COM port.
            {
                MessageBox.Show("Please select a COM port occupied by the slider!");
            }
            else
            {
                
                Port.portName = comboBox1.Items[item].ToString();

                if (Baud115Radio.Checked == true)
                {
                    Port.baudRate = 115200;
                }
                else if (Baud9600Radio.Checked == true)
                {
                    Port.baudRate = 9600;
                }
                else
                {
                    MessageBox.Show("Please select a baud rate!");
                }

                Form1 main = new Form1();
                main.Show();
                this.Hide();
            }
            
        }
    }
}
