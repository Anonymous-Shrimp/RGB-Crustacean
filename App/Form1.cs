

/*
By Anonymous Shrimp
https://youtube.com/channel/UCs2Sz1gPlWAdET5qcLcZCJw
https://github.com/Anonymous-Shrimp 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace RGB_Crustacean
{
    public partial class Form : System.Windows.Forms.Form
    {
        String[] ports;
        SerialPort port;
        public Gradient[] palettes;

        public Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {

            try
            {
                
                string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                port.Open();
                label4.Text = "";
                button1.Text = "Disconnect";
                enableControls();
            }
            catch
            {
                Console.WriteLine("Connection Error");
                label4.Text = "Connection Error";
            }


        }
    }
    public class Gradient
    {
        public String name;
        public Color[] color;
        public int[] pos;
    }
    
}
