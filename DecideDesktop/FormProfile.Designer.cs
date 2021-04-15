
namespace DecideDesktop
{
    partial class FormProfile
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
            this.comboBoxChoiseCurrency = new System.Windows.Forms.ComboBox();
            this.labelAddCurrency = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTemp = new System.Windows.Forms.Panel();
            this.panelFill = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWalletHavent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelTemp.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxChoiseCurrency
            // 
            this.comboBoxChoiseCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.comboBoxChoiseCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiseCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxChoiseCurrency.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChoiseCurrency.ForeColor = System.Drawing.Color.White;
            this.comboBoxChoiseCurrency.FormattingEnabled = true;
            this.comboBoxChoiseCurrency.Items.AddRange(new object[] {
            "BTC",
            "ETH",
            "LTC",
            "XRP"});
            this.comboBoxChoiseCurrency.Location = new System.Drawing.Point(47, 16);
            this.comboBoxChoiseCurrency.Name = "comboBoxChoiseCurrency";
            this.comboBoxChoiseCurrency.Size = new System.Drawing.Size(158, 26);
            this.comboBoxChoiseCurrency.TabIndex = 0;
            // 
            // labelAddCurrency
            // 
            this.labelAddCurrency.AutoSize = true;
            this.labelAddCurrency.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddCurrency.ForeColor = System.Drawing.Color.White;
            this.labelAddCurrency.Location = new System.Drawing.Point(12, 9);
            this.labelAddCurrency.Name = "labelAddCurrency";
            this.labelAddCurrency.Size = new System.Drawing.Size(29, 33);
            this.labelAddCurrency.TabIndex = 1;
            this.labelAddCurrency.Text = "+";
            this.labelAddCurrency.Click += new System.EventHandler(this.label1_Click);
            this.labelAddCurrency.MouseLeave += new System.EventHandler(this.labelAddCurrency_MouseLeave);
            this.labelAddCurrency.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelAddCurrency_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.labelAddCurrency);
            this.panel1.Controls.Add(this.comboBoxChoiseCurrency);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 53);
            this.panel1.TabIndex = 2;
            // 
            // panelTemp
            // 
            this.panelTemp.Controls.Add(this.label3);
            this.panelTemp.Controls.Add(this.label2);
            this.panelTemp.Controls.Add(this.label1);
            this.panelTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTemp.Location = new System.Drawing.Point(0, 53);
            this.panelTemp.Name = "panelTemp";
            this.panelTemp.Size = new System.Drawing.Size(712, 33);
            this.panelTemp.TabIndex = 4;
            // 
            // panelFill
            // 
            this.panelFill.AutoScroll = true;
            this.panelFill.Controls.Add(this.labelWalletHavent);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 86);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(712, 328);
            this.panelFill.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Валюта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(425, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Процент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(224, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // labelWalletHavent
            // 
            this.labelWalletHavent.AutoSize = true;
            this.labelWalletHavent.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWalletHavent.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelWalletHavent.Location = new System.Drawing.Point(243, 32);
            this.labelWalletHavent.Name = "labelWalletHavent";
            this.labelWalletHavent.Size = new System.Drawing.Size(192, 21);
            this.labelWalletHavent.TabIndex = 0;
            this.labelWalletHavent.Text = "У вас еще нет кошельков";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(712, 414);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTemp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(712, 414);
            this.Name = "FormProfile";
            this.ShowInTaskbar = false;
            this.Text = "FormProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTemp.ResumeLayout(false);
            this.panelTemp.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoiseCurrency;
        private System.Windows.Forms.Label labelAddCurrency;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTemp;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWalletHavent;
    }
}