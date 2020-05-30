using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyBattery
{
    public partial class Form1 : Form
    {
        private int levelcharge = 100;
        DialogResult result = DialogResult.Yes;
        private bool showMessages = true;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Black;
            TransparencyKey = Color.Black;
        }

        public sealed override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.STRAppName;
            timer1.Interval = 250;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            float levelBattery = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            string chargeBattery = SystemInformation.PowerStatus.BatteryChargeStatus.ToString();
            bool isRunningOnBattery = (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus ==
                                       PowerLineStatus.Offline);
            checkCharge(chargeBattery, levelBattery, isRunningOnBattery);
            notifyIcon1.Icon = PIcon(levelBattery, chargeBattery, levelcharge, isRunningOnBattery);
            if (chargeBattery.Contains("Charging"))
            {
                levelcharge = levelCharge(levelcharge);
                notifyIcon1.Text = Properties.Resources.STRCharging +
                                   SystemInformation.PowerStatus.BatteryLifePercent * 100 +
                                   Properties.Resources.STRRemaining;
            }
            else
            {
                notifyIcon1.Text = SystemInformation.PowerStatus.BatteryLifePercent * 100 +
                                   Properties.Resources.STRRemaining;
            }
        }

        private void checkCharge(string chargeBattery, float levelBattery, bool isRunningOnBattery)
        {
            if (showMessages)
            {
                if (levelBattery >= Properties.Settings.Default.maxCharge)
                {
                    if (chargeBattery.Contains("Charging"))
                    {
                        showMessages = false;
                        //result = MessageBox.Show( ... MessageBoxOptions.DefaultDesktopOnly);
                        result = MessageBox.Show(Properties.Resources.STRChargeUnneed, this.Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                    }
                    if (!isRunningOnBattery)
                    {
                        showMessages = false;
                        //result = MessageBox.Show( ... MessageBoxOptions.DefaultDesktopOnly);
                        result = MessageBox.Show(Properties.Resources.STRChargeUnneed, this.Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                    }
                }
                else if (levelBattery <= Properties.Settings.Default.minCharge)
                {
                    if (!chargeBattery.Contains("Charging"))
                    {
                        showMessages = false;
                        //result = MessageBox.Show( ... MessageBoxOptions.DefaultDesktopOnly);
                        result = MessageBox.Show(Properties.Resources.STRChargeNeed, this.Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                    }
                }
            }
            if (result == DialogResult.OK)
            {
                result = DialogResult.Yes;
                showMessages = true;
            }
        }

        private int levelCharge(int levelcharge)
        {
            switch (levelcharge)
            {
                case 100:
                    return 0;
                case 75:
                    return 100;
                case 50:
                    return 75;
                case 25:
                    return 50;
                case 0:
                    return 25;
            }
            return -1;
        }

        public static Icon PIcon(float levelBattery, string chargeBattery, int levelcharge, bool isRunningOnBattery)
        {
            if (chargeBattery == "High, Charging")
            {
                return Properties.Resources.BatteryF;
            }
            if (chargeBattery == "High" && !isRunningOnBattery)
            {
                return Properties.Resources.BatteryF;
            }
            if (chargeBattery == "Charging")
            {
                levelBattery = levelcharge;
            }
            if (levelBattery >= 75)
            {
                return Properties.Resources.Battery3;
            }
            if (levelBattery >= 50)
            {
                return Properties.Resources.Battery2;
            }
            if (levelBattery >= 25)
            {
                return Properties.Resources.Battery1;
            }
            return Properties.Resources.Battery0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = Properties.Resources.CreatedBY;
            message = message.Replace("↵", "\n");
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }

        private void windowsMobilityCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "explorer.exe";
            startInfo.Arguments = "shell:::{5ea4f148-308c-46d7-98a9-49041b1dd468}";
            Process.Start(startInfo);
        }

        private void powerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("powercfg.cpl");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
