using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotifyBattery.Properties;

namespace NotifyBattery
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadDefaultValues();
        }

        private void LoadDefaultValues()
        {
            numericUpDown1.Text = Settings.Default.maxCharge.ToString();
            numericUpDown2.Text = Settings.Default.minCharge.ToString();
            chkSTRIsNotifityMaxCharge.Checked = Settings.Default.isNotifityMaxCharge;
            chkSTRIsNotifityMinCharge.Checked = Settings.Default.isNotifityMinCharge;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.maxCharge = Convert.ToInt32(numericUpDown1.Text);
            Settings.Default.minCharge = Convert.ToInt32(numericUpDown2.Text);
            Settings.Default.isNotifityMaxCharge = chkSTRIsNotifityMaxCharge.Checked;
            Settings.Default.isNotifityMinCharge = chkSTRIsNotifityMinCharge.Checked;
            Settings.Default.Save();
            Close();
        }
    }
}
