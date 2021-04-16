
namespace DecideDesktop
{
    partial class ViewSignIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSignIn));
            this.panelProfileSignIn = new System.Windows.Forms.Panel();
            this.textBoxSignInProfile = new System.Windows.Forms.TextBox();
            this.picProfSignIn = new System.Windows.Forms.PictureBox();
            this.panelPasswordSignIn = new System.Windows.Forms.Panel();
            this.textBoxSignInPassword = new System.Windows.Forms.TextBox();
            this.picPassSignIn = new System.Windows.Forms.PictureBox();
            this.labelDBosh = new System.Windows.Forms.Label();
            this.picVKSignIn = new System.Windows.Forms.PictureBox();
            this.picGoogleSignIn = new System.Windows.Forms.PictureBox();
            this.picInstSignIn = new System.Windows.Forms.PictureBox();
            this.buttonSignUpSignIn = new System.Windows.Forms.Button();
            this.buttonSignInSignIn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelLocation = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picProfSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVKSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoogleSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstSignIn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProfileSignIn
            // 
            this.panelProfileSignIn.BackColor = System.Drawing.Color.White;
            this.panelProfileSignIn.Location = new System.Drawing.Point(18, 210);
            this.panelProfileSignIn.Name = "panelProfileSignIn";
            this.panelProfileSignIn.Size = new System.Drawing.Size(325, 1);
            this.panelProfileSignIn.TabIndex = 6;
            // 
            // textBoxSignInProfile
            // 
            this.textBoxSignInProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxSignInProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSignInProfile.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSignInProfile.ForeColor = System.Drawing.Color.White;
            this.textBoxSignInProfile.HideSelection = false;
            this.textBoxSignInProfile.Location = new System.Drawing.Point(46, 183);
            this.textBoxSignInProfile.Multiline = true;
            this.textBoxSignInProfile.Name = "textBoxSignInProfile";
            this.textBoxSignInProfile.Size = new System.Drawing.Size(297, 21);
            this.textBoxSignInProfile.TabIndex = 5;
            this.textBoxSignInProfile.TabStop = false;
            this.textBoxSignInProfile.Text = "Почта";
            this.textBoxSignInProfile.Click += new System.EventHandler(this.textBoxSignInProfile_Click);
            // 
            // picProfSignIn
            // 
            this.picProfSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.picProfSignIn.BackgroundImage = global::DecideDesktop.Properties.Resources.icon_email_white;
            this.picProfSignIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.picProfSignIn.InitialImage = null;
            this.picProfSignIn.Location = new System.Drawing.Point(18, 183);
            this.picProfSignIn.Name = "picProfSignIn";
            this.picProfSignIn.Size = new System.Drawing.Size(21, 21);
            this.picProfSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfSignIn.TabIndex = 4;
            this.picProfSignIn.TabStop = false;
            // 
            // panelPasswordSignIn
            // 
            this.panelPasswordSignIn.BackColor = System.Drawing.Color.White;
            this.panelPasswordSignIn.Location = new System.Drawing.Point(18, 278);
            this.panelPasswordSignIn.Name = "panelPasswordSignIn";
            this.panelPasswordSignIn.Size = new System.Drawing.Size(325, 1);
            this.panelPasswordSignIn.TabIndex = 9;
            // 
            // textBoxSignInPassword
            // 
            this.textBoxSignInPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxSignInPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSignInPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSignInPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxSignInPassword.HideSelection = false;
            this.textBoxSignInPassword.Location = new System.Drawing.Point(46, 251);
            this.textBoxSignInPassword.Multiline = true;
            this.textBoxSignInPassword.Name = "textBoxSignInPassword";
            this.textBoxSignInPassword.Size = new System.Drawing.Size(297, 21);
            this.textBoxSignInPassword.TabIndex = 8;
            this.textBoxSignInPassword.TabStop = false;
            this.textBoxSignInPassword.Text = "Пароль";
            this.textBoxSignInPassword.Click += new System.EventHandler(this.textBoxSignInPassword_Click);
            // 
            // picPassSignIn
            // 
            this.picPassSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.picPassSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPassSignIn.BackgroundImage")));
            this.picPassSignIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPassSignIn.InitialImage = null;
            this.picPassSignIn.Location = new System.Drawing.Point(18, 251);
            this.picPassSignIn.Name = "picPassSignIn";
            this.picPassSignIn.Size = new System.Drawing.Size(22, 20);
            this.picPassSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassSignIn.TabIndex = 7;
            this.picPassSignIn.TabStop = false;
            // 
            // labelDBosh
            // 
            this.labelDBosh.AutoSize = true;
            this.labelDBosh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.labelDBosh.Font = new System.Drawing.Font("Montserrat Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDBosh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(179)))), ((int)(((byte)(6)))));
            this.labelDBosh.Location = new System.Drawing.Point(76, 54);
            this.labelDBosh.Name = "labelDBosh";
            this.labelDBosh.Size = new System.Drawing.Size(198, 66);
            this.labelDBosh.TabIndex = 10;
            this.labelDBosh.Text = "D.Bosh";
            // 
            // picVKSignIn
            // 
            this.picVKSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.picVKSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVKSignIn.BackgroundImage")));
            this.picVKSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVKSignIn.InitialImage = null;
            this.picVKSignIn.Location = new System.Drawing.Point(239, 451);
            this.picVKSignIn.Name = "picVKSignIn";
            this.picVKSignIn.Size = new System.Drawing.Size(52, 54);
            this.picVKSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVKSignIn.TabIndex = 14;
            this.picVKSignIn.TabStop = false;
            this.picVKSignIn.Click += new System.EventHandler(this.picVKSignIn_Click);
            // 
            // picGoogleSignIn
            // 
            this.picGoogleSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.picGoogleSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGoogleSignIn.BackgroundImage")));
            this.picGoogleSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGoogleSignIn.InitialImage = null;
            this.picGoogleSignIn.Location = new System.Drawing.Point(150, 451);
            this.picGoogleSignIn.Name = "picGoogleSignIn";
            this.picGoogleSignIn.Size = new System.Drawing.Size(52, 54);
            this.picGoogleSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGoogleSignIn.TabIndex = 13;
            this.picGoogleSignIn.TabStop = false;
            this.picGoogleSignIn.Click += new System.EventHandler(this.picGoogleSignIn_Click);
            // 
            // picInstSignIn
            // 
            this.picInstSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.picInstSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInstSignIn.BackgroundImage")));
            this.picInstSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInstSignIn.InitialImage = null;
            this.picInstSignIn.Location = new System.Drawing.Point(58, 451);
            this.picInstSignIn.Name = "picInstSignIn";
            this.picInstSignIn.Size = new System.Drawing.Size(52, 54);
            this.picInstSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInstSignIn.TabIndex = 12;
            this.picInstSignIn.TabStop = false;
            this.picInstSignIn.Click += new System.EventHandler(this.picInstSignIn_Click);
            // 
            // buttonSignUpSignIn
            // 
            this.buttonSignUpSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonSignUpSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignUpSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUpSignIn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUpSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(179)))), ((int)(((byte)(6)))));
            this.buttonSignUpSignIn.Location = new System.Drawing.Point(46, 361);
            this.buttonSignUpSignIn.Name = "buttonSignUpSignIn";
            this.buttonSignUpSignIn.Size = new System.Drawing.Size(259, 33);
            this.buttonSignUpSignIn.TabIndex = 16;
            this.buttonSignUpSignIn.Text = "Зарегистрироваться";
            this.buttonSignUpSignIn.UseVisualStyleBackColor = false;
            this.buttonSignUpSignIn.Click += new System.EventHandler(this.buttonSignUpSignIn_Click);
            // 
            // buttonSignInSignIn
            // 
            this.buttonSignInSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(179)))), ((int)(((byte)(6)))));
            this.buttonSignInSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignInSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSignInSignIn.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignInSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignInSignIn.Location = new System.Drawing.Point(46, 312);
            this.buttonSignInSignIn.Name = "buttonSignInSignIn";
            this.buttonSignInSignIn.Size = new System.Drawing.Size(259, 33);
            this.buttonSignInSignIn.TabIndex = 15;
            this.buttonSignInSignIn.Text = "Войти";
            this.buttonSignInSignIn.UseVisualStyleBackColor = false;
            this.buttonSignInSignIn.Click += new System.EventHandler(this.buttonSignInSignIn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelLocation
            // 
            this.panelLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLocation.Location = new System.Drawing.Point(0, 0);
            this.panelLocation.Name = "panelLocation";
            this.panelLocation.Size = new System.Drawing.Size(361, 35);
            this.panelLocation.TabIndex = 19;
            this.panelLocation.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLocation_Paint);
            this.panelLocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelLocation_MouseClick);
            this.panelLocation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLocation_MouseDown);
            this.panelLocation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLocation_MouseMove);
            this.panelLocation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLocation_MouseUp);
            // 
            // ViewSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(361, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSignUpSignIn);
            this.Controls.Add(this.buttonSignInSignIn);
            this.Controls.Add(this.picVKSignIn);
            this.Controls.Add(this.picGoogleSignIn);
            this.Controls.Add(this.picInstSignIn);
            this.Controls.Add(this.labelDBosh);
            this.Controls.Add(this.panelPasswordSignIn);
            this.Controls.Add(this.textBoxSignInPassword);
            this.Controls.Add(this.picPassSignIn);
            this.Controls.Add(this.panelProfileSignIn);
            this.Controls.Add(this.textBoxSignInProfile);
            this.Controls.Add(this.picProfSignIn);
            this.Controls.Add(this.panelLocation);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.ViewSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVKSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoogleSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstSignIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProfileSignIn;
        private System.Windows.Forms.TextBox textBoxSignInProfile;
        private System.Windows.Forms.PictureBox picProfSignIn;
        private System.Windows.Forms.Panel panelPasswordSignIn;
        private System.Windows.Forms.TextBox textBoxSignInPassword;
        private System.Windows.Forms.PictureBox picPassSignIn;
        private System.Windows.Forms.Label labelDBosh;
        private System.Windows.Forms.PictureBox picVKSignIn;
        private System.Windows.Forms.PictureBox picGoogleSignIn;
        private System.Windows.Forms.PictureBox picInstSignIn;
        private System.Windows.Forms.Button buttonSignUpSignIn;
        private System.Windows.Forms.Button buttonSignInSignIn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLocation;
    }
}