using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            }
            else if (!isOn)
            {
                StartStopButton.Text = "Stop";
                isOn = true;
            }
        }

        //Main cycle
        private void tickTime_Tick(object sender, EventArgs e)
        {
            if(!isFileLinked) { return; }
            if(!isOn) { return; }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainChart.Series["MB"].Points.Clear();
        }
    }
}
