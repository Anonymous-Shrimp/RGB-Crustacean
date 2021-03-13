

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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.CompilerServices;
using RGB_Crustacean.Properties;
using Tulpep.NotificationWindow;

namespace RGB_Crustacean
{

    public partial class Form : System.Windows.Forms.Form
    {
        String[] ports;
        public Device[] devices = { new Device(), new Device(), new Device() };
        public FolderBrowserDialog fbd;
        public BinaryFormatter formatter = new BinaryFormatter();
        public Gradient palettes;
        public Label errortext;
        public int currentGradientPointIndex = 0;
        public Form()
        {
            InitializeComponent();
            getAvailableComPorts();

            fbd = dataPath;

            errortext = errorText;
            errorText.Text = "";
            if (Settings.Default["pathName"] != null)
            {
                dataPathText.Text = "Path set to: " + Settings.Default["pathName"].ToString();
            }
            else
            {
                dataPathText.Text = "";
            }
            

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
            GradientBox.Paint += new PaintEventHandler(this.GradientBox_Paint);
            palettes = new Gradient();
            this.Controls.Add(GradientBox);
            if (dataPath.SelectedPath != null)
            {
                LoadPlayer();
                updateColorPage();
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
                connectToArduino(2);
            }
            else
            {
                disconnectFromArduino(2);
            }
        }
        private void serialLabel1_Click(object sender, EventArgs e)
        {
            serialText1.Visible = false;
            serialText2.Visible = false;
            serialText3.Visible = false;

            serialLabel1.Visible = true;
            serialLabel2.Visible = true;
            serialLabel3.Visible = true;
            serialText1.Visible = true;
            serialLabel1.Visible = false;
            serialText1.Text = serialLabel1.Text;
        }

        private void serialLabel2_Click(object sender, EventArgs e)
        {
            serialText1.Visible = false;
            serialText2.Visible = false;
            serialText3.Visible = false;

            serialLabel1.Visible = true;
            serialLabel2.Visible = true;
            serialLabel3.Visible = true;
            serialText2.Visible = true;
            serialLabel2.Visible = false;
            serialText2.Text = serialLabel2.Text;
        }
        
        private void serialLabel3_Click(object sender, EventArgs e)
        {
            serialText1.Visible = false;
            serialText2.Visible = false;
            serialText3.Visible = false;

            serialLabel1.Visible = true;
            serialLabel2.Visible = true;
            serialLabel3.Visible = true;
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

            serialLabel1.Visible = true;
            serialLabel2.Visible = true;
            serialLabel3.Visible = true;
        }

        private void GradientBox_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush br = new LinearGradientBrush(GradientBox.DisplayRectangle, Color.Black, Color.Black, 0, false);
            ColorBlend cb = new ColorBlend();
            try
            {
                cb.Positions = palettes.pos;
                cb.Colors = palettes.color;
            }
            catch
            {
                Console.WriteLine("Error Drawing Gradient");
            }
            try
            {
                br.InterpolationColors = cb;
                br.RotateTransform(0);
                e.Graphics.FillRectangle(br, GradientBox.DisplayRectangle);
            }
            catch
            {
                Console.WriteLine(palettes.pos);
            }

        }

        void updateColorPage()
        {
            GradientBox.Refresh();
            UpdateList();
            if (dataPath.SelectedPath != null)
            {
                SavePlayer();
            }
            UpdateScrollBars();
            UpdateList();
        }
        public void UpdateScrollBars()
        {
            r.Value = palettes.color[currentGradientPointIndex].R;
            g.Value = palettes.color[currentGradientPointIndex].G;
            b.Value = palettes.color[currentGradientPointIndex].B;
            pos.Value = (int)Math.Round(palettes.pos[currentGradientPointIndex] * 1000);
            bool isLargest = true;
            bool isSmallest = true;
            foreach (float p in palettes.pos)
            {
                if(p > palettes.pos[currentGradientPointIndex])
                {
                    isLargest = false;
                }
                if (p < palettes.pos[currentGradientPointIndex])
                {
                    isSmallest = false;
                }
            }
            pos.Enabled = !(isLargest || isSmallest);

        }
        private void r_Scroll(object sender, EventArgs e)
        {
            palettes.color[currentGradientPointIndex] = Color.FromArgb(r.Value, g.Value, b.Value);
            updateColorPage();
        }

        private void g_Scroll(object sender, EventArgs e)
        {
            palettes.color[currentGradientPointIndex] = Color.FromArgb(r.Value, g.Value, b.Value);
            updateColorPage();
        }

        private void b_Scroll(object sender, EventArgs e)
        {
            palettes.color[currentGradientPointIndex] = Color.FromArgb(r.Value, g.Value, b.Value);
            updateColorPage();
        }

        private void resetGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            palettes = new Gradient();
            updateColorPage();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }
        public void SavePlayer()
        {
            SaveSystem.SavePlayer(this);
            Settings.Default["pathName"] = dataPath.SelectedPath;
            
        }
        public void LoadPlayer()
        {
            SaveData data = SaveSystem.LoadPlayer(this);
            //palettes = data.palettes;
            fbd.SelectedPath = Settings.Default["pathName"].ToString();
            updateColorPage();
        }

        private void browseData_Click(object sender, EventArgs e)
        {
            dataPath.ShowDialog();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(dataPath.SelectedPath != null)
            {
                SavePlayer();
            }
        }

        private void Form_MouseHover(object sender, EventArgs e)
        {
            dataPathText.TextAlign = ContentAlignment.MiddleCenter;
            if (dataPath.SelectedPath != null)
            {
                dataPathText.Text = "Path set to: " + Settings.Default["pathName"].ToString();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (dataPath.SelectedPath != null)
            {
                LoadPlayer();
                updateColorPage();
                dataPathText.Text = "Path set to: " + Settings.Default["pathName"].ToString();
            }
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "BE HAPPY";
            popup.ContentText = "Thank you";
            popup.Popup();
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dataPath.SelectedPath != null)
            {
                dataPathText.Text = "Path set to: " + Settings.Default["pathName"].ToString();
            }
        }

        private void gradientStopList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentGradientPointIndex = gradientStopList.SelectedIndex;
            UpdateScrollBars();
            UpdateList();
            
        }
        public void UpdateList()
        {
            gradientStopList.Items.Clear();
            for (int i = 0; i < palettes.color.Length; i++)
            {
                Color c = palettes.color[i];
                string RGBtext = c.R.ToString() + ", " + c.G.ToString() + ", " + c.B.ToString() + ", ";
                string outputText = RGBtext + " at " + palettes.pos[i].ToString();
                gradientStopList.Items.Add(outputText);
                
            }
        }

        private void pos_Scroll(object sender, EventArgs e)
        {
            palettes.pos[currentGradientPointIndex] = pos.Value / 1000;
            SortColors();
            updateColorPage();
        }

        private void addStop_Click(object sender, EventArgs e)
        {
            List<Color> currentColors = palettes.color.ToList();
            List<float> currentPos = palettes.pos.ToList();
            currentColors.Add(Color.White);
            currentPos.Add(0.5f);
            palettes.color = currentColors.ToArray();
            palettes.pos = currentPos.ToArray();
            SortColors();
            updateColorPage();
        }
        public void SortColors()
        {
            palettes.pos.ToList().Sort();
        }

    }
    [Serializable]
    public class Gradient
    {
        public string name = "MyGradient";
        public Color[] color = { Color.Black, Color.White};
        public float[] pos = { 0, 1 };

        
    }
    [Serializable]
    public class Device
    {
        public string name;
        public SerialPort port;
        public bool isConnected = false;
        public Button button;
        public TextBox nameBox;
        public ComboBox selection;
    }
    

public static class SaveSystem
    {
        public static void SavePlayer(Form save)
        {


            
            string path = save.fbd.SelectedPath + "/RGBCrustaceanGradient.col";
            FileStream stream = new FileStream(path, FileMode.Create);

            SaveData data = new SaveData(save);
            try
            {
                save.formatter.Serialize(stream, data);
            }catch(Exception e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                save.errortext.Text = "Error Saving File";
            }
            finally
            {
                stream.Close();
            }
            
        }
        public static SaveData LoadPlayer(Form save)
        {
            string path = save.fbd.SelectedPath + "/RGBCrustaceanGradient.col";
            if (File.Exists(path))
            {
                
                FileStream stream = new FileStream(path, FileMode.Open);



                SaveData data = save.formatter.Deserialize(stream) as SaveData;

                stream.Close();

                Console.WriteLine("Loaded File From " + path);

                return data;
            }
            else
            {
                Console.WriteLine("Save File not found in " + path);
                save.errortext.Text = "Save File not found in " + path;
                return null;
            }
        }
    }
    
    

    [Serializable]
    public class SaveData
    {

        public Gradient palettes;

        public SaveData(Form save)
        {
            palettes = save.palettes;
        }

    }

}

