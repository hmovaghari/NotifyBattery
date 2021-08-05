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
using NotifyBattery.Properties;

namespace NotifyBattery
{
    public partial class frmMain : Form
    {
        private int levelcharge = 100;
        DialogResult result = DialogResult.Yes;
        private bool showMessages = true;

        public frmMain()
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            Size = new Size(0, 0);
            timer.Interval = 250;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            float levelBattery = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            string chargeBattery = SystemInformation.PowerStatus.BatteryChargeStatus.ToString();
            bool isRunningOnBattery = (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus ==
                                       PowerLineStatus.Offline);
            checkCharge(chargeBattery, levelBattery, isRunningOnBattery);
            notifyIcon.Icon = PIcon(levelBattery, chargeBattery, levelcharge, isRunningOnBattery);

            notifyIcon.Text = string.Empty;
            if (chargeBattery.Contains("Charging"))
            {
                levelcharge = levelCharge(levelcharge);
                notifyIcon.Text = "Charging ";
            }
            notifyIcon.Text += SystemInformation.PowerStatus.BatteryLifePercent * 100;
            notifyIcon.Text += "% Remaining";
        }

        private void checkCharge(string chargeBattery, float levelBattery, bool isRunningOnBattery)
        {
            if (showMessages)
            {
                if (levelBattery >= Settings.Default.maxCharge)
                {
                    if (Settings.Default.isNotifityMaxCharge)
                    {
                        var chargeUnneed = "Battery is High Level, Please disconnect from Adapter";
                        if (chargeBattery.Contains("Charging"))
                        {
                            showMessages = false;
                            //result = MessageBox.Show( ... MessageBoxOptions.DefaultDesktopOnly);
                            result = MessageBox.Show(chargeUnneed, Text, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.ServiceNotification);
                        }
                        if (!isRunningOnBattery)
                        {
                            showMessages = false;
                            //result = MessageBox.Show( ... MessageBoxOptions.DefaultDesktopOnly);
                            result = MessageBox.Show(chargeUnneed, Text, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.ServiceNotification);
                        }
                    }
                }
                else if (levelBattery <= Settings.Default.minCharge)
                {
                    if (Settings.Default.isNotifityMinCharge)
                    {
                        if (!chargeBattery.Contains("Charging"))
                        {
                            showMessages = false;
                            //result = MessageBox.Show( ... MessageBoxOptions.DefaultDesktopOnly);
                            result = MessageBox.Show("Battery is Low Level, Please connect to Adapter",
                                Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.ServiceNotification);
                        }
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
                return Resources.BatteryF;
            }
            if (chargeBattery == "High" && !isRunningOnBattery)
            {
                return Resources.BatteryF;
            }
            if (chargeBattery == "Charging")
            {
                levelBattery = levelcharge;
            }
            if (levelBattery >= 75)
            {
                return Resources.Battery3;
            }
            if (levelBattery >= 50)
            {
                return Resources.Battery2;
            }
            if (levelBattery >= 25)
            {
                return Resources.Battery1;
            }
            return Resources.Battery0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Created by hmovaghari↵http://hmovaghari.rozblog.com";
            message = message.Replace("↵", "\n");
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
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
            frmSettings form2 = new frmSettings();
            form2.ShowDialog();
        }
    }
}
