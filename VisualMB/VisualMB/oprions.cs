using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualMB.Properties;

namespace VisualMB
{
    public partial class oprions : Form
    {
        private readonly Form1 _form1;
        public oprions(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void SaveOptionsButton_Click(object sender, EventArgs e)
        {

            if (!Double.TryParse(BcalText.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double check_Bcal))
            {
                Settings.Default.B_cal = Double.Parse(BcalText.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            }
            if (!Double.TryParse(McalText.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double check_Mcal))
            {
                Settings.Default.M_cal = Double.Parse(McalText.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            }

            switch(COMportBox.SelectedIndex)
            {
                case 0: Settings.Default.COMname = "COM3"; break;
                case 1: Settings.Default.COMname = "COM4"; break;
                case 2: Settings.Default.COMname = "COM5"; break;
                case 3: Settings.Default.COMname = "COM6"; break;
                case 4: Settings.Default.COMname = "COM7"; break;
                case 5: Settings.Default.COMname = "COM8"; break;
            }

            this._form1.SettingsChanged();
            Settings.Default.Save();
        }



        private void oprions_Load(object sender, EventArgs e)
        {
            COMportBox.SelectedIndex = COMportBox.Items.IndexOf(Settings.Default.COMname);

            McalText.Text = Settings.Default.M_cal.ToString();
            BcalText.Text = Settings.Default.B_cal.ToString();
        }

        private void oprions_FormClosing(object sender, FormClosingEventArgs e)
        {
            COMportBox.SelectedIndex = COMportBox.Items.IndexOf(Settings.Default.COMname);

            McalText.Text = Settings.Default.M_cal.ToString();
            BcalText.Text = Settings.Default.B_cal.ToString();
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
    }
}
