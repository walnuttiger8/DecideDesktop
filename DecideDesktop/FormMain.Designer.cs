
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1day = new System.Windows.Forms.Button();
            this.btn1hour = new System.Windows.Forms.Button();
            this.btn15min = new System.Windows.Forms.Button();
            this.btnlive = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Graphic = new LiveCharts.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btn1day);
            this.panel1.Controls.Add(this.btn1hour);
            this.panel1.Controls.Add(this.btn15min);
            this.panel1.Controls.Add(this.btnlive);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 53);
            this.panel1.TabIndex = 0;
            // 
            // btn1day
            // 
            this.btn1day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.btn1day.FlatAppearance.BorderSize = 0;
            this.btn1day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1day.Font = new System.Drawing.Font("Montserrat Light", 12F);
            this.btn1day.ForeColor = System.Drawing.Color.White;
            this.btn1day.Location = new System.Drawing.Point(291, 7);
            this.btn1day.Name = "btn1day";
            this.btn1day.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn1day.Size = new System.Drawing.Size(90, 35);
            this.btn1day.TabIndex = 3;
            this.btn1day.Text = "1 день";
            this.btn1day.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1day.UseVisualStyleBackColor = false;
            this.btn1day.Click += new System.EventHandler(this.btn1day_Click);
            // 
            // btn1hour
            // 
            this.btn1hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.btn1hour.FlatAppearance.BorderSize = 0;
            this.btn1hour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1hour.Font = new System.Drawing.Font("Montserrat Light", 12F);
            this.btn1hour.ForeColor = System.Drawing.Color.White;
            this.btn1hour.Location = new System.Drawing.Point(195, 7);
            this.btn1hour.Name = "btn1hour";
            this.btn1hour.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn1hour.Size = new System.Drawing.Size(90, 35);
            this.btn1hour.TabIndex = 2;
            this.btn1hour.Text = "1 час";
            this.btn1hour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1hour.UseVisualStyleBackColor = false;
            this.btn1hour.Click += new System.EventHandler(this.btn1hour_Click);
            // 
            // btn15min
            // 
            this.btn15min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.btn15min.FlatAppearance.BorderSize = 0;
            this.btn15min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15min.Font = new System.Drawing.Font("Montserrat Light", 12F);
            this.btn15min.ForeColor = System.Drawing.Color.White;
            this.btn15min.Location = new System.Drawing.Point(99, 7);
            this.btn15min.Name = "btn15min";
            this.btn15min.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn15min.Size = new System.Drawing.Size(90, 35);
            this.btn15min.TabIndex = 1;
            this.btn15min.Text = "15 мин";
            this.btn15min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn15min.UseVisualStyleBackColor = false;
            this.btn15min.Click += new System.EventHandler(this.btn15min_Click);
            // 
            // btnlive
            // 
            this.btnlive.BackColor = System.Drawing.Color.Brown;
            this.btnlive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlive.Font = new System.Drawing.Font("Montserrat Light", 10F);
            this.btnlive.ForeColor = System.Drawing.Color.White;
            this.btnlive.Location = new System.Drawing.Point(48, 10);
            this.btnlive.Name = "btnlive";
            this.btnlive.Size = new System.Drawing.Size(41, 28);
            this.btnlive.TabIndex = 0;
            this.btnlive.Text = "live";
            this.btnlive.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlive.UseVisualStyleBackColor = false;
            this.btnlive.Click += new System.EventHandler(this.btnlive_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Graphic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 322);
            this.panel2.TabIndex = 1;
            // 
            // Graphic
            // 
            this.Graphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Graphic.Location = new System.Drawing.Point(0, 0);
            this.Graphic.Name = "Graphic";
            this.Graphic.Size = new System.Drawing.Size(696, 322);
            this.Graphic.TabIndex = 0;
            this.Graphic.Text = "cartesianChart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(696, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LiveCharts.WinForms.CartesianChart Graphic;
        private System.Windows.Forms.Button btnlive;
        private System.Windows.Forms.Button btn1day;
        private System.Windows.Forms.Button btn1hour;
        private System.Windows.Forms.Button btn15min;
    }
}