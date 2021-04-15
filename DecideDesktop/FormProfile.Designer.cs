
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
            this.panelFill = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            // panelFill
            // 
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 53);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(712, 361);
            this.panelFill.TabIndex = 3;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(712, 414);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(712, 414);
            this.Name = "FormProfile";
            this.ShowInTaskbar = false;
            this.Text = "FormProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoiseCurrency;
        private System.Windows.Forms.Label labelAddCurrency;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFill;
    }
}