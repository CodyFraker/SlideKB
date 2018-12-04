using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliderConsole
{
    public partial class Form1 : Form
    {
        private delegate void LineReceivedEvent(string input);
        public Form1()
        {
            InitializeComponent();
            serialPort1.BaudRate = Port.baudRate;
            serialPort1.PortName = Port.portName;
            serialPort1.Open();
            serialPort1.DataReceived += SerialPort1_DataReceived;
            comport_label.Text = Port.portName; // Sets the port name Label
            baudrate_label.Text = Port.baudRate.ToString(); // Sets the baud rate label
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string input = serialPort1.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), input);
        }
        
        private void LineReceived(string input)
        {
            var test = serialPort1;
            int curentValue = 0;

            curentValue = int.Parse(input);

            progressBar1.Value = curentValue;
            sliderVal.Text = curentValue.ToString();
            richTextBox1.AppendText(input);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
