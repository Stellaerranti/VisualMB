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

namespace VisualMB
{
    public partial class Form1 : Form
    {
        private string outputFile;
        private bool isFileLinked = false;
        private bool isOn= false;

        private int counter = 1;

        private float M = 0;
        private float B = 0;

        System.Timers.Timer aTimer;

        //private SerialPort port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

        public Form1()
        {
            InitializeComponent();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            MainChart.Series["MB"].Points.Clear();

            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(checkPort);
            aTimer.Interval = 100;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  var timer = new System.Threading.Timer(_ => checkPort(), null, 0, 100);
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
                aTimer.Enabled = false;

                //tickTime.Enabled = false;
                inputPort.Close();
            }
            else if (!isOn)
            {
                StartStopButton.Text = "Stop";
                isOn = true;

                //tickTime.Enabled = true;
                inputPort.Open();

                aTimer.Enabled = true;

                counter = 0;
                M = 0;
                B = 0;
            }
        }

        private void displayData(double B, double M)
        {          

            counter++;

            if (counter == 5)
            {
                
                M = M / counter;
                B = B / counter;

                MainChart.Series["MB"].Points.AddXY(B, M);

                File.WriteAllText(outputFile,B.ToString() +"\t"+M.ToString()+"\n");

                BLabel.Text = B.ToString();
                MLabel.Text = M.ToString();

                M = 0;
                B = 0;

                counter = 1;

            }

            /*MainChart.Series["MB"].Points.AddXY(B, M);

            File.WriteAllText(outputFile, B.ToString() + "\t" + M.ToString() + "\n");

            BLabel.Text = B.ToString();
            MLabel.Text = M.ToString();

            M = 0;
            B = 0;*/
        }


        /*private void displayData()
        {
            MainChart.Series["MB"].Points.AddXY(0,0);
        }*/
        //Main cycle
        private void checkPort(object source, ElapsedEventArgs e)
        {
            /*
            if (!isFileLinked) { return; }
            if (!isOn) { return; }

            //if (!inputPort.IsOpen)
              //  inputPort.Open();

            try
            {
                string[] input = inputPort.ReadLine().Split();

                //string in1 = inputPort.ReadLine();
                //B = B + float.Parse(input[0], CultureInfo.InvariantCulture.NumberFormat);
                //M = M + float.Parse(input[1], CultureInfo.InvariantCulture.NumberFormat);
                B = float.Parse(input[0], CultureInfo.InvariantCulture.NumberFormat);
                M = float.Parse(input[1], CultureInfo.InvariantCulture.NumberFormat);
                Invoke((MethodInvoker)(() => displayData(B,M)));

                //Invoke((MethodInvoker)(() => displayData()));
            }
            catch { }

            //inputPort.Close();
            */
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

                //string in1 = inputPort.ReadLine();
                B = B + float.Parse(input[0], CultureInfo.InvariantCulture.NumberFormat);
                M = M + float.Parse(input[1], CultureInfo.InvariantCulture.NumberFormat);
                //B = float.Parse(input[0], CultureInfo.InvariantCulture.NumberFormat);
                //M = float.Parse(input[1], CultureInfo.InvariantCulture.NumberFormat);
                Invoke((MethodInvoker)(() => displayData(B, M)));
                //displayData(B, M);
                //Invoke((MethodInvoker)(() => displayData()));
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
    }
}
