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
using System.Windows.Forms;

namespace VisualMB
{
    public partial class Form1 : Form
    {
        private string outputFile;
        private bool isFileLinked = false;
        private bool isOn= false;

        private int counter = 0;

        private float M = 0;
        private float B = 0;

        //private SerialPort port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

        public Form1()
        {
            InitializeComponent();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            MainChart.Series["MB"].Points.Clear();
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

                tickTime.Enabled = false;
                inputPort.Close();
            }
            else if (!isOn)
            {
                StartStopButton.Text = "Stop";
                isOn = true;

                tickTime.Enabled = true;
                inputPort.Open();

                counter = 0;
                M = 0;
                B = 0;
            }
        }

        //Main cycle
        private void tickTime_Tick(object sender, EventArgs e)
        {
            if(!isFileLinked) { return; }
            if(!isOn) { return; }

            string[] input = inputPort.ReadLine().Split();

            B = B + float.Parse(input[0], CultureInfo.InvariantCulture.NumberFormat);
            M = M + float.Parse(input[1], CultureInfo.InvariantCulture.NumberFormat);

            counter++;

            if (counter == 5)
            {
                counter = 0;

                M = M / 5;
                B = B / 5;

                MainChart.Series["MB"].Points.AddXY(B, M);

                M = 0;
                B = 0;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainChart.Series["MB"].Points.Clear();
        }

        private void inputPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            isOn = false;
            tickTime.Enabled = false;
            StartStopButton.Text = "Start";
            inputPort.Close();
            MessageBox.Show("Can't read from port");
        }

        private void inputPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }
    }
}
