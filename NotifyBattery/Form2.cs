using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyBattery
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //this.Text = ((TextBox)form1.Controls["textBox1"]).Text;
            //this.Text = ((string)form1.Text);
            //this.Text = form1.Text;
            this.Text = Properties.Resources.STRAppName;
            label1.Text = Properties.Resources.STRMaxCharge;
            label2.Text = Properties.Resources.STRMinCharge;
            numericUpDown1.Text = Properties.Settings.Default.maxCharge.ToString();
            numericUpDown2.Text = Properties.Settings.Default.minCharge.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericUpDown1.Text) > Convert.ToInt32(numericUpDown2.Text))
            {
                Properties.Settings.Default.maxCharge = Convert.ToInt32(numericUpDown1.Text);
                Properties.Settings.Default.minCharge = Convert.ToInt32(numericUpDown2.Text);
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show(Properties.Resources.STRInvalidData, this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
        }
    }
}
