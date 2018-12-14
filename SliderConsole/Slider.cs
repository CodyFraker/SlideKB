using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SliderConsole
{
    public class Slider
    {
        public string portName = string.Empty; // SlideKB USB Port
        public int baudRate = 115200; // Default Baud Rate set by SlideKB
        public string Id = string.Empty;
        private delegate void LineReceivedEvent(string input);
        public SerialPort serial;

        public void initialize()
        {
            serial = new SerialPort();
            serial.PortName = portName;
            serial.BaudRate = baudRate; 
            serial.Open(); // Opens the serial connection to the arudino.
            GetID(); // Gets the ID/Name of the slider. It appears to the the revision for the Arduino Code
        }

        private void GetID()
        {
            serial.Write("2424]");
            string input;
            input = serial.ReadLine().ToString();
            if (input.Equals("l1n117\r"))
            {
                Id = "l1n117";
            }
        }
    }
}
