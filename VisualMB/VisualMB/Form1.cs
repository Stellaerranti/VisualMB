using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.LinkLabel;

namespace VisualMB
{
    public partial class Form1 : Form
    {
        private string outputFile;
        private bool isFileLinked = false;
        private bool isOn= false;

        StreamWriter file;

        private double M = 0;
        private double B = 0;

        private double B_cal;
        private double M_cal;
       
        //private SerialPort port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

        public Form1()
        {
            InitializeComponent();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            MainChart.Series["MB"].Points.Clear();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            B_cal = 1;
            M_cal = 1;

            COMportBox.SelectedIndex = 0;
        }

        //Подключаем файл
        private void fileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) { return; }

            outputFile = saveFileDialog.FileName;
            fileLabel.Text = Path.GetFileName(outputFile);

            isFileLinked = true;
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {

            if (isOn)
            {
                StartStopButton.Text = "Start";
                isOn = false;

                if (inputPort.IsOpen) { inputPort.Close(); }
               
            }
            else if (!isOn)
            {             

                try { 
                inputPort.Open();
                }
                catch { MessageBox.Show("Can' connect to " + inputPort.PortName); return; }
                StartStopButton.Text = "Stop";
                isOn = true;
                M = 0;
                B = 0;
            }
        }

        private void displayData()
        {
            
            try
            {
                B = B * B_cal;
                M = M * M_cal;

                MainChart.Series["MB"].Points.AddXY(B, M);

                using (StreamWriter file = new StreamWriter(outputFile,true))
                {
                    file.WriteLine(B.ToString("F3") + "\t" + M.ToString("F3"));
                }

                BLabel.Text = B.ToString("F3");
                MLabel.Text = M.ToString("F3");

                M = 0;
                B = 0;
            }
            catch { }
        }
       

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainChart.Series["MB"].Points.Clear();
        }

        private void inputPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            isOn = false;
            //tickTime.Enabled = false;
            StartStopButton.Text = "Start";
            inputPort.Close();
            MessageBox.Show("Can't read from port");
        }

        private void inputPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isFileLinked) { return; }
            if (!isOn) { return; }
            try
            {
                string[] input = inputPort.ReadLine().Split();

                B = float.Parse(input[0], CultureInfo.InvariantCulture.NumberFormat);
                M = float.Parse(input[1], CultureInfo.InvariantCulture.NumberFormat);

                Invoke((MethodInvoker)(() => displayData()));

            }
            catch { }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!inputPort.IsOpen)
              inputPort.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!inputPort.IsOpen)
                inputPort.Close();
        }      

        private void BcalText_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(BcalText.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double check))
            { 
                B_cal = double.Parse(BcalText.Text, NumberStyles.Any, CultureInfo.InvariantCulture); 
            }
        }

        private void McalText_TextChanged(object sender, EventArgs e)
        {            
            if (Double.TryParse(McalText.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double check))
            { 
                M_cal = double.Parse(McalText.Text, NumberStyles.Any, CultureInfo.InvariantCulture); 
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            switch(COMportBox.SelectedIndex) 
            {
                case 0: inputPort.PortName = "COM1"; break;
                case 1: inputPort.PortName = "COM2"; break;
                case 2: inputPort.PortName = "COM3"; break;
                case 3: inputPort.PortName = "COM4"; break;
            }
        }
    }
}
