
namespace DecideDesktop
{
    partial class FormMain
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
            this.BTCGraphic = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // BTCGraphic
            // 
            this.BTCGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTCGraphic.ForeColor = System.Drawing.Color.White;
            this.BTCGraphic.Location = new System.Drawing.Point(0, 0);
            this.BTCGraphic.Name = "BTCGraphic";
            this.BTCGraphic.Size = new System.Drawing.Size(696, 375);
            this.BTCGraphic.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(696, 375);
            this.Controls.Add(this.BTCGraphic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart BTCGraphic;
    }
}