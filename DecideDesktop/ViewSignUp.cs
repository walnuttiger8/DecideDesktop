using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DecideDesktop;

namespace DecideDesktop
{
    public partial class ViewSignUp : Form
    {
        public ViewSignUp()
        {
            //hello
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static ViewSignIn SignIn = new ViewSignIn();

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxProfileSignUp.Clear();
            picProfSignUp.BackgroundImage =Properties.Resources.profile_yellow;
            panelProfile.BackColor = Color.FromArgb(215, 179, 6);
            textBoxProfileSignUp.ForeColor = Color.FromArgb(215, 179, 6);

            picPassSignUp.BackgroundImage = Properties.Resources.pass_white;
            panelPassword.BackColor = Color.White;
            textBoxPasswordSignUp.ForeColor = Color.White;

            picEmailSignUp.BackgroundImage = Properties.Resources.icon_email_white;
            panelEmail.BackColor = Color.White;
            textBoxEmailSignUp.ForeColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBoxPasswordSignUp.Clear();
            textBoxPasswordSignUp.PasswordChar = '⬤';
            
            picPassSignUp.BackgroundImage = Properties.Resources.password_yellow;
            panelPassword.BackColor = Color.FromArgb(215, 179, 6);
            textBoxPasswordSignUp.ForeColor = Color.FromArgb(215, 179, 6);

            picProfSignUp.BackgroundImage = Properties.Resources.profile_whitesmall;
            panelProfile.BackColor = Color.White;
            textBoxProfileSignUp.ForeColor = Color.White;

            picEmailSignUp.BackgroundImage = Properties.Resources.icon_email_white;
            panelEmail.BackColor = Color.White;
            textBoxEmailSignUp.ForeColor = Color.White;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBoxEmailSignUp.Clear();
            picEmailSignUp.BackgroundImage = Properties.Resources.email_yellow;
            panelEmail.BackColor = Color.FromArgb(215, 179, 6);
            textBoxEmailSignUp.ForeColor = Color.FromArgb(215, 179, 6);

            picPassSignUp.BackgroundImage = Properties.Resources.pass_white;
            panelPassword.BackColor = Color.White;
            textBoxPasswordSignUp.ForeColor = Color.White;

            picProfSignUp.BackgroundImage = Properties.Resources.profile_whitesmall;
            panelProfile.BackColor = Color.White;
            textBoxProfileSignUp.ForeColor = Color.White;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SignIn.Left += 10;
            if (SignIn.Left >= 860)
            {
                timer1.Stop();
                this.TopMost = false;
                SignIn.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SignIn.Left -= 10;
            if (SignIn.Left <= 510)
            {
                timer2.Stop();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picInstSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.instagram.com/decide.elevator/?hl=ru");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно открыть ссылку.");
            }
        }

        private void picGoogleSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://kartli.ch/ru/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно открыть ссылку.");
            }
        }

        private void picVKSignUp_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("https://vk.com/decidetodevelop");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно открыть ссылку.");
            }
        }

        private void buttonSignInSignUp_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> SignUpValues = new Dictionary<string, string>();
            SignUpValues.Add("UserName", textBoxProfileSignUp.Text);
            SignUpValues.Add("Password", textBoxPasswordSignUp.Text);
            SignUpValues.Add("EMail", textBoxEmailSignUp.Text);
            //вызов метода Олега
        }
    }
}
