

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
using System.Linq;
using System.Dynamic;
using System.Configuration;
using System.Xml;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Drawing.Drawing2D;
using System.Net.Http.Headers;
using System.Diagnostics;

namespace RGB_Crustacean
{
    public partial class Form : System.Windows.Forms.Form
    {
        String[] ports;
        Device[] devices = { new Device(), new Device(), new Device() };

        PaintEventArgs draw;

        List<Gradient> palettes;
        Gradient[] startPalettes = new Gradient[] { new Gradient() };

        int index = 0;

        public Form()
        {
            InitializeComponent();
            getAvailableComPorts();

            if(palettes == null)
            {
                palettes = startPalettes.ToList();
            }

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

            gradientName.Visible = true;
            gradientText.Visible = false;

            gradientName.Text = palettes[index].name;

            foreach (Gradient g in palettes)
            {
                gradientList.Items.Add(g.name);
            }

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
            updateList();
            GradientBox.Paint += new PaintEventHandler(this.GradientBox_Paint);
            this.Controls.Add(GradientBox);

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

        void MainFormPaint(object sender, PaintEventArgs e)
        {
            
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
        

        

        private void Form1_Click(object sender, EventArgs e)
        {


            serialText1.Visible = false;
            serialText2.Visible = false;
            serialText3.Visible = false;
            gradientText.Visible = false;

            serialLabel1.Visible = true;
            serialLabel2.Visible = true;
            serialLabel3.Visible = true;
            gradientName.Visible = true;
        }

        private void GradientBox_Paint(object sender, PaintEventArgs e)
        {
            draw = e;
            LinearGradientBrush br = new LinearGradientBrush(GradientBox.DisplayRectangle, Color.Black, Color.Black, 0, false);
            ColorBlend cb = new ColorBlend();
            try
            {
                cb.Positions = palettes[gradientList.SelectedIndex].pos;
                cb.Colors = palettes[gradientList.SelectedIndex].color;
            }
            catch
            {
                cb.Positions = palettes[0].pos;
                cb.Colors = palettes[0].color;
                Console.WriteLine("Error Drawing Gradient");
            }
            br.InterpolationColors = cb;
            br.RotateTransform(0);
            e.Graphics.FillRectangle(br, GradientBox.DisplayRectangle);

        }

        void updateColorPage()
        {
            /*
            LinearGradientBrush br = new LinearGradientBrush(GradientBox.DisplayRectangle, Color.Black, Color.Black, 0, false);
            ColorBlend cb = new ColorBlend();
            try
            {
                cb.Positions = palettes[gradientList.SelectedIndex].pos;
                cb.Colors = palettes[gradientList.SelectedIndex].color;
            }
            catch
            {
                cb.Positions = palettes[0].pos;
                cb.Colors = palettes[0].color;
                Console.WriteLine("Error Drawing Gradient");
            }
            br.InterpolationColors = cb;
            br.RotateTransform(0);
            draw.Graphics.FillRectangle(br, GradientBox.DisplayRectangle);
            */

            r.Value = palettes[index].color[0].R;
            g.Value = palettes[index].color[0].G;
            b.Value = palettes[index].color[0].B;
            gradientName.Text = palettes[index].name;
        }

        private void gradientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gradientText.Visible)
            {
                gradientText.Visible = false;
                gradientName.Visible = true;
                gradientName.Text = gradientText.Text;
                palettes[index].name = gradientText.Text;
            }
            index = gradientList.SelectedIndex;
            updateColorPage();
            updateList();
        }

        private void AddGradient_Click(object sender, EventArgs e)
        {
            palettes.Add(new Gradient());
            updateList();
            gradientList.SelectedIndex = palettes.Count - 1;
        }
        void updateList()
        {
            object i = gradientList.SelectedItem;

            gradientList.Items.Clear();

            foreach(Gradient g in palettes)
            {
                gradientList.Items.Add(g.name);
            }
            gradientList.SelectedItem = i;
            

        }


       

        private void deleteList_Click(object sender, EventArgs e)
        {
            palettes.RemoveAt(gradientList.SelectedIndex);
            gradientList.SelectedIndex = 0;
            updateList();
        }

        private void duplicateList_Click(object sender, EventArgs e)
        {
            palettes.Add(palettes[gradientList.SelectedIndex]);
            
            updateList();
            gradientList.SelectedIndex = palettes.Count - 1;
        }

        private void listContextMenu_Opened(object sender, EventArgs e)
        {
            deleteList.Enabled = gradientList.SelectedItem != null;
            duplicateList.Enabled = gradientList.SelectedItem != null;
            if (gradientList.Items.Count == 1)
            {
                deleteList.Enabled = false;
            }
            else
            {
                deleteList.Enabled = true;
            }
           
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gradientName.Text = gradientText.Text;
            palettes[index].name = gradientText.Text;
            updateList();
        }

        private void gradientName_Click(object sender, EventArgs e)
        {
            gradientText.Visible = true;
            gradientName.Visible = false;
            gradientText.Text = gradientName.Text;
        }

        private void r_Scroll(object sender, EventArgs e)
        {
            palettes[index].color[0] = Color.FromArgb(r.Value, g.Value, b.Value);
        }

        private void g_Scroll(object sender, EventArgs e)
        {
            palettes[index].color[0] = Color.FromArgb(r.Value, g.Value, b.Value);
        }

        private void b_Scroll(object sender, EventArgs e)
        {
            palettes[index].color[0] = Color.FromArgb(r.Value, g.Value, b.Value);
        }
    }

    public class Gradient
    {
        public string name = "MyGradient";
        public Color[] color = { Color.Black, Color.White};
        public float[] pos = { 0, 1 };

        
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
