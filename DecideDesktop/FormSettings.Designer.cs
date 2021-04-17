
namespace DecideDesktop
{
    partial class FormSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUserBalance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTopUp = new System.Windows.Forms.Label();
            this.textBoxTopUp = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.labelUserBalance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 53);
            this.panel1.TabIndex = 3;
            // 
            // labelUserBalance
            // 
            this.labelUserBalance.AutoSize = true;
            this.labelUserBalance.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserBalance.ForeColor = System.Drawing.Color.White;
            this.labelUserBalance.Location = new System.Drawing.Point(45, 18);
            this.labelUserBalance.Name = "labelUserBalance";
            this.labelUserBalance.Size = new System.Drawing.Size(88, 26);
            this.labelUserBalance.TabIndex = 3;
            this.labelUserBalance.Text = "Баланс:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBoxTopUp);
            this.panel2.Controls.Add(this.labelTopUp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 103);
            this.panel2.TabIndex = 4;
            // 
            // labelTopUp
            // 
            this.labelTopUp.AutoSize = true;
            this.labelTopUp.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTopUp.ForeColor = System.Drawing.Color.White;
            this.labelTopUp.Location = new System.Drawing.Point(33, 31);
            this.labelTopUp.Name = "labelTopUp";
            this.labelTopUp.Size = new System.Drawing.Size(123, 26);
            this.labelTopUp.TabIndex = 6;
            this.labelTopUp.Text = "Пополнить";
            this.labelTopUp.Click += new System.EventHandler(this.labelTopUp_Click);
            this.labelTopUp.MouseLeave += new System.EventHandler(this.labelTopUp_MouseLeave);
            this.labelTopUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTopUp_MouseMove);
            // 
            // textBoxTopUp
            // 
            this.textBoxTopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.textBoxTopUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTopUp.Font = new System.Drawing.Font("Montserrat Light", 14F);
            this.textBoxTopUp.ForeColor = System.Drawing.Color.White;
            this.textBoxTopUp.Location = new System.Drawing.Point(162, 27);
            this.textBoxTopUp.Name = "textBoxTopUp";
            this.textBoxTopUp.Size = new System.Drawing.Size(238, 30);
            this.textBoxTopUp.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(25, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 1);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(696, 176);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Уровень риска :";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(46, 72);
            this.trackBar1.Maximum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(277, 45);
            this.trackBar1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(12, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 38);
            this.panel5.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(22, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Низкий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Light", 10F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(126, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Умеренный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Light", 10F);
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(263, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Высокий";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(696, 375);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelUserBalance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxTopUp;
        public System.Windows.Forms.Label labelTopUp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar trackBar1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
    }
}