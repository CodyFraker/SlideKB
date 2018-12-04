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
            serialPort1.BaudRate = 115200;
            serialPort1.PortName = "COM7";
            serialPort1.Open();
            serialPort1.DataReceived += SerialPort1_DataReceived;
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
    }
}
