
namespace DecideDesktop
{
    partial class FormHistory
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
            this.comboBoxChoiseCurrency = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFillHistory = new System.Windows.Forms.Panel();
            this.labelTransactionHavent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFillHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.comboBoxChoiseCurrency);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 53);
            this.panel1.TabIndex = 0;
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
            "Все валюты"});
            this.comboBoxChoiseCurrency.Location = new System.Drawing.Point(47, 16);
            this.comboBoxChoiseCurrency.Name = "comboBoxChoiseCurrency";
            this.comboBoxChoiseCurrency.Size = new System.Drawing.Size(158, 26);
            this.comboBoxChoiseCurrency.TabIndex = 2;
            this.comboBoxChoiseCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoiseCurrency_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 33);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(563, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(376, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Баланс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Валюта";
            // 
            // panelFillHistory
            // 
            this.panelFillHistory.AutoScroll = true;
            this.panelFillHistory.Controls.Add(this.labelTransactionHavent);
            this.panelFillHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFillHistory.Location = new System.Drawing.Point(0, 86);
            this.panelFillHistory.Name = "panelFillHistory";
            this.panelFillHistory.Size = new System.Drawing.Size(696, 289);
            this.panelFillHistory.TabIndex = 2;
            // 
            // labelTransactionHavent
            // 
            this.labelTransactionHavent.AutoSize = true;
            this.labelTransactionHavent.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTransactionHavent.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelTransactionHavent.Location = new System.Drawing.Point(278, 25);
            this.labelTransactionHavent.Name = "labelTransactionHavent";
            this.labelTransactionHavent.Size = new System.Drawing.Size(17, 26);
            this.labelTransactionHavent.TabIndex = 0;
            this.labelTransactionHavent.Text = " ";
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(696, 375);
            this.Controls.Add(this.panelFillHistory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistory";
            this.Text = "FormHistory";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFillHistory.ResumeLayout(false);
            this.panelFillHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxChoiseCurrency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFillHistory;
        private System.Windows.Forms.Label labelTransactionHavent;
    }
}