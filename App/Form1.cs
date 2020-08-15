

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
using System.IO;
using System.Net.Http.Headers;


namespace RGB_Crustacean
{
    public partial class Form : System.Windows.Forms.Form
    {
        String[] ports;
        Device[] devices = { new Device(), new Device(), new Device() };

        Gradient[] palettes;

        
        public Form()
        {
            InitializeComponent();
            getAvailableComPorts();

            errorText.Text = "";

            devices[0].button = serialButton1;
            devices[1].button = serialButton2;
            devices[2].button = serialButton3;

            devices[0].selection = serial1;
            devices[1].selection = serial2;
            devices[2].selection = serial3;

            devices[1].button.Text = "Connect";
            devices[2].button.Text = "Connect";
            devices[0].button.Text = "Connect";

            devices[0].nameBox = serialText1;
            devices[1].nameBox = serialText2;
            devices[2].nameBox = serialText3;

            serialText1.Text = devices[0].name;
            serialText2.Text = devices[1].name;
            serialText3.Text = devices[2].name;

            serialText1.Visible = false;
            serialText2.Visible = false;
            serialText3.Visible = false;

            serialLabel1.Visible = true;
            serialLabel2.Visible = true;
            serialLabel3.Visible = true;
            
            serialLabel1.Text = "Device1";
            serialLabel2.Text = "Device2";
            serialLabel3.Text = "Device3";


            foreach (string port in ports)
            {
                serial1.Items.Add(port);
                serial2.Items.Add(port);
                serial3.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    serial1.SelectedItem = ports[0];
                    serial2.SelectedItem = ports[0];
                    serial3.SelectedItem = ports[0];
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino(int port)
        {

            try
            {
                Device device = devices[port];
                string selectedPort = device.selection.GetItemText(device.selection.SelectedItem);
                
                device.isConnected = true;
                device.port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                device.port.Open();
                device.port.Close();
                device.button.Text = "Disconnect";
                errorText.Text = "";
                if(port == 0)
                {
                    serial1.Enabled = false;
                }else if(port == 1)
                {
                    serial2.Enabled = false;
                }else if(port == 2)
                {
                    serial3.Enabled = false;
                }
            }
            catch
            {
                Console.WriteLine("Connection Error");
                errorText.Text = "Connection Error";
            }


        }

        private void disconnectFromArduino(int port)
        {
            Device device = devices[port];
            try
            {
                
                device.isConnected = false;
                device.port.Open();
                device.port.Write("#STOP\n");
                device.port.Close();
                Console.WriteLine("#STOP\n");
                errorText.Text = "";
                device.button.Text = "Connect";
                if (port == 0)
                {
                    serial1.Enabled = true;
                }
                else if (port == 1)
                {
                    serial2.Enabled = true;
                }
                else if (port == 2)
                {
                    serial3.Enabled = true;
                }
            }
            catch
            {
                Console.WriteLine("Connection Error");
                errorText.Text = "Connection Error"; 
            }
        }

        private void serial1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serial2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serial3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serialButton1_Click(object sender, EventArgs e)
        {
            if (!devices[0].isConnected)
            {
                connectToArduino(0);
            }
            else
            {
                disconnectFromArduino(0);
            }
        }

        private void serialButton2_Click(object sender, EventArgs e)
        {
            if (!devices[1].isConnected)
            {
                connectToArduino(1);
            }
            else
            {
                disconnectFromArduino(1);
            }
        }

        private void serialButton3_Click(object sender, EventArgs e)
        {
            if (!devices[2].isConnected)
            {
                connectToArduino(0);
            }
            else
            {
                disconnectFromArduino(0);
            }
        }
        private void serialLabel1_Click(object sender, EventArgs e)
        {
            serialText1.Visible = true;
            serialLabel1.Visible = false;
            serialText1.Text = serialLabel1.Text;
        }

        private void serialLabel2_Click(object sender, EventArgs e)
        {
            serialText2.Visible = true;
            serialLabel2.Visible = false;
            serialText2.Text = serialLabel2.Text;
        }
        
        private void serialLabel3_Click(object sender, EventArgs e)
        {
            serialText3.Visible = true;
            serialLabel3.Visible = false;
            serialText3.Text = serialLabel3.Text;
        }

        private void serialText1_TextChanged(object sender, EventArgs e)
        {
            serialLabel1.Text = serialText1.Text;
            devices[0].name = serialText2.Text;
        }

        private void serialText2_TextChanged(object sender, EventArgs e)
        {
            serialLabel2.Text = serialText2.Text;
            devices[1].name = serialText2.Text;
        }

        private void serialText3_TextChanged(object sender, EventArgs e)
        {
            serialLabel3.Text = serialText3.Text;
            devices[2].name = serialText3.Text;
        }

        private void errorText_Click(object sender, EventArgs e)
        {
            errorText.Text = "";
        }
        void saveDevices(Device device)
        {
            TextWriter txt = new StreamWriter("/device.txt");
            txt.Write(device.name);
            txt.Close();
        }

        

        private void Form1_Click(object sender, EventArgs e)
        {


            serialText1.Visible = false;
            serialText2.Visible = false;
            serialText3.Visible = false;

            serialLabel1.Visible = true;
            serialLabel2.Visible = true;
            serialLabel3.Visible = true;
        }
    }
    public class Gradient
    {
        public string name;
        public Color[] color;
        public int[] pos;
    }
    public class Device
    {
        public string name;
        public SerialPort port;
        public bool isConnected = false;
        public Button button;
        public TextBox nameBox;
        public ComboBox selection;
        

    }
    
}
