using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecideDesktop
{
    public partial class ViewSignIn : Form
    {
        public ViewSignIn()
        {
            InitializeComponent();
        }

        ViewSignUp SignUp = new ViewSignUp();

        private void buttonSignUpSignIn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SignUp.Left += 10;
            if(SignUp.Left>=860)
            {
                timer1.Stop();
                this.TopMost = false;
                SignUp.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SignUp.Left -= 10;
            if(SignUp.Left<=510)
            {
                timer2.Stop();

            }
        }

        private void ViewSignIn_Load(object sender, EventArgs e)
        {
            ViewSignUp.SignIn = this;
            SignUp.Show();
        }

        private void textBoxSignInProfile_Click(object sender, EventArgs e)
        {
            textBoxSignInProfile.Clear();

            picProfSignIn.BackgroundImage = Properties.Resources.profile_yellow;
            panelProfileSignIn.BackColor = Color.FromArgb(215, 179, 6);
            textBoxSignInProfile.ForeColor = Color.FromArgb(215, 179, 6);

            picPassSignIn.BackgroundImage = Properties.Resources.pass_white;
            panelPasswordSignIn.BackColor = Color.White;
            textBoxSignInPassword.ForeColor = Color.White;
        }

        private void textBoxSignInPassword_Click(object sender, EventArgs e)
        {
            textBoxSignInPassword.Clear();
            textBoxSignInPassword.PasswordChar = '⬤';

            picPassSignIn.BackgroundImage = Properties.Resources.password_yellow;
            panelPasswordSignIn.BackColor = Color.FromArgb(215, 179, 6);
            textBoxSignInPassword.ForeColor = Color.FromArgb(215, 179, 6);

            picProfSignIn.BackgroundImage = Properties.Resources.profile_whitesmall;
            panelProfileSignIn.BackColor = Color.White;
            textBoxSignInProfile.ForeColor = Color.White;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picInstSignIn_Click(object sender, EventArgs e)
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

        private void picGoogleSignIn_Click(object sender, EventArgs e)
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

        private void picVKSignIn_Click(object sender, EventArgs e)
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

        private void buttonSignInSignIn_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> SignInValues = new Dictionary<string, object>();
            SignInValues.Add("username", textBoxSignInProfile.Text);
            SignInValues.Add("password", textBoxSignInPassword.Text);

            if (UserController.LogIn(HTTPClient.Address, ViewSignUp.thisUser))
            {
                MessageBox.Show("Вы вошли");
            }
            else
            {
                MessageBox.Show("Нет, не вошли");
            }
            
        }
    }
}
