namespace NotifyBattery
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSTRMaxCharge = new System.Windows.Forms.Label();
            this.lblSTRMinCharge = new System.Windows.Forms.Label();
            this.chkSTRIsNotifityMaxCharge = new System.Windows.Forms.CheckBox();
            this.chkSTRIsNotifityMinCharge = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(260, 9);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point(260, 40);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown2.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(134, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // lblSTRMaxCharge
            // 
            this.lblSTRMaxCharge.AutoSize = true;
            this.lblSTRMaxCharge.Location = new System.Drawing.Point(9, 13);
            this.lblSTRMaxCharge.Name = "lblSTRMaxCharge";
            this.lblSTRMaxCharge.Size = new System.Drawing.Size(221, 13);
            this.lblSTRMaxCharge.TabIndex = 0;
            this.lblSTRMaxCharge.Text = "Maximum Charge for disconnect from Adapter";
            // 
            // lblSTRMinCharge
            // 
            this.lblSTRMinCharge.AutoSize = true;
            this.lblSTRMinCharge.Location = new System.Drawing.Point(9, 43);
            this.lblSTRMinCharge.Name = "lblSTRMinCharge";
            this.lblSTRMinCharge.Size = new System.Drawing.Size(197, 13);
            this.lblSTRMinCharge.TabIndex = 1;
            this.lblSTRMinCharge.Text = "Minimum Charge for connect to  Adapter";
            // 
            // chkSTRIsNotifityMaxCharge
            // 
            this.chkSTRIsNotifityMaxCharge.AutoSize = true;
            this.chkSTRIsNotifityMaxCharge.Location = new System.Drawing.Point(12, 74);
            this.chkSTRIsNotifityMaxCharge.Name = "chkSTRIsNotifityMaxCharge";
            this.chkSTRIsNotifityMaxCharge.Size = new System.Drawing.Size(330, 17);
            this.chkSTRIsNotifityMaxCharge.TabIndex = 5;
            this.chkSTRIsNotifityMaxCharge.Text = "Is notification for \"Maximum Charge for disconnect from Adapter\"";
            this.chkSTRIsNotifityMaxCharge.UseVisualStyleBackColor = true;
            // 
            // chkSTRIsNotifityMinCharge
            // 
            this.chkSTRIsNotifityMinCharge.AutoSize = true;
            this.chkSTRIsNotifityMinCharge.Location = new System.Drawing.Point(12, 108);
            this.chkSTRIsNotifityMinCharge.Name = "chkSTRIsNotifityMinCharge";
            this.chkSTRIsNotifityMinCharge.Size = new System.Drawing.Size(306, 17);
            this.chkSTRIsNotifityMinCharge.TabIndex = 6;
            this.chkSTRIsNotifityMinCharge.Text = "Is notification for \"Minimum Charge for connect to  Adapter\"";
            this.chkSTRIsNotifityMinCharge.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 184);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSTRMaxCharge);
            this.panel1.Controls.Add(this.chkSTRIsNotifityMinCharge);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.lblSTRMinCharge);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.chkSTRIsNotifityMaxCharge);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 127);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 45);
            this.panel2.TabIndex = 1;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 184);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotifyBattery - Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSTRMaxCharge;
        private System.Windows.Forms.Label lblSTRMinCharge;
        private System.Windows.Forms.CheckBox chkSTRIsNotifityMaxCharge;
        private System.Windows.Forms.CheckBox chkSTRIsNotifityMinCharge;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}