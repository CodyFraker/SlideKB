﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using AudioSwitcher;
using AudioSwitcher.AudioApi.CoreAudio;

namespace SliderConsole
{
    public partial class Form1 : Form
    {
        Slider slide1;
        CoreAudioDevice playbackDevice = new CoreAudioController().DefaultPlaybackDevice;
        public Form1(Slider slider)
        {
            InitializeComponent();
            slide1 = slider;

            try
            {
                sliderNameLabel.Text = slide1.Id;

            }
            catch(System.UnauthorizedAccessException e1)
            {
                MessageBox.Show("Could not reach port. Could be occupied by another process such as Arduino IDE Console. \n" +
                    "Try to close those applications before proceeding.");
                this.Close();
            }
            slide1.serial.DataReceived += Serial_DataReceived;
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string input = slide1.serial.ReadLine(); // Reads the incomming data
            this.BeginInvoke(new LineReceivedEvent(LineReceived), input);
        }
        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string input)
        {
                int curentValue = 0;
                curentValue = int.Parse(input);
                progressBar1.Value = curentValue;
                double sliderPercent = (Convert.ToDouble(curentValue) / 1022.00) * 100.00;
                sliderVal100.Text = sliderPercent.ToString();
            if(checkBox1.Checked == true)
            {
                playbackDevice.SetVolumeAsync(sliderPercent);
            }
                sliderVal.Text = curentValue.ToString();
                richTextBox1.AppendText(input);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vibrateCycles = 10;
            switch(trackBar1.Value)
            {
                case 0:
                    vibrateCycles = 0;
                    break;
                case 1:
                    vibrateCycles = 10;
                    break;
                case 2:
                    vibrateCycles = 20;
                    break;
                case 3:
                    vibrateCycles = 30;
                    break;
                case 4:
                    vibrateCycles = 40;
                    break;
                case 5:
                    vibrateCycles = 50;
                    break;
                case 6:
                    vibrateCycles = 60;
                    break;
                case 7:
                    vibrateCycles = 70;
                    break;
                case 8:
                    vibrateCycles = 80;
                    break;
                case 9:
                    vibrateCycles = 90;
                    break;
                default:
                    vibrateCycles = 40;
                    break;
            }
            slide1.serial.Write($"60{vibrateCycles}]"); // Sends string to arduino to vibrate the device.
            // String has to be within 6001-6999 technically.
            // Ex: "6999" would technically vibrate the device for a long time.
            // "6040" much shorter vibrate
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comport_label.Text = slide1.portName; // Sets the port name Label
            baudrate_label.Text = slide1.baudRate.ToString(); // Sets the baud rate label
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            slide1.serial.Write($"1024]");  // Set slider's position to home.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ($"Current Volume: {playbackDevice.Volume}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playbackDevice.SetVolumeAsync(50);
            richTextBox1.Text = "Set volume to 50";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                richTextBox1.Text = "";
                richTextBox1.AppendText("Syncing slider position with volume.");
                richTextBox1.Text = ($"Current Volume: {playbackDevice.Volume}");

                slide1.serial.Write($"1024]");  // Set slider's position to home.
                double vol = (Convert.ToDouble(playbackDevice.Volume) / 100.00) * 1022.00; // Convert volume to 0-1022
                richTextBox1.AppendText($"VOLUME TO SEND TO SLIDER: {vol}");
                slide1.serial.Write($"{vol}]"); //Set slider's position to the match the master volume. 

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
