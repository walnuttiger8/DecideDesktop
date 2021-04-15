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
using DecideDesktop.Classes;

namespace DecideDesktop
{
    public partial class ViewSignUp : Form
    {
        internal static int thisUserId = 0;
        public ViewSignUp()
        {
            //hello
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ViewMain.SignUp = this;
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

        int forTimer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            forTimer += 1;
            SignIn.Left += 10;
            
            if (forTimer == 36)
            {
                timer1.Stop();
                
                this.TopMost = false;
                SignIn.TopMost = true;
                timer2.Start();
            }

        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            forTimer -= 1;
            SignIn.Left -= 10;
            if (forTimer == 0)
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
            if(Classes.FieldsCheck.UserNameCheck(textBoxProfileSignUp.Text) &&
                Classes.FieldsCheck.PasswordCheck(textBoxPasswordSignUp.Text) &&
                    Classes.FieldsCheck.EMailCheck(textBoxEmailSignUp.Text))
            {
                Dictionary<string, object> SignUpValues = new Dictionary<string, object>();
                SignUpValues.Add("username", textBoxProfileSignUp.Text);
                SignUpValues.Add("password", textBoxPasswordSignUp.Text);
                SignUpValues.Add("email", textBoxEmailSignUp.Text);

                thisUserId = UserController.SignUp(HTTPClient.Address, SignUpValues);
                if (thisUserId != 0)
                {
                    MessageBox.Show("Успех зарегаться");
                }
                else
                {
                    MessageBox.Show("Неудача зарегаться");

                }
            }
            else
            {
                textBoxEmailSignUp.ForeColor = Color.Red;
                textBoxPasswordSignUp.ForeColor = Color.Red;
                textBoxProfileSignUp.ForeColor = Color.Red;
                panelEmail.BackColor = Color.Red;
                panelPassword.BackColor = Color.Red;
                panelProfile.BackColor = Color.Red;
            }
        }
        private bool isMousePress = false;
        private Point _clickPoint;
        private Point _formStartPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePress = true;
            _clickPoint = Cursor.Position;
            _formStartPoint = Location;
            SignIn.Location = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePress)
            {
                var cursorOffsetPoint = new Point( //считаем смещение курсора от старта
                    Cursor.Position.X - _clickPoint.X,
                    Cursor.Position.Y - _clickPoint.Y);

                Location = new Point( //смещаем форму от начальной позиции в соответствии со смещением курсора
                    _formStartPoint.X + cursorOffsetPoint.X,
                    _formStartPoint.Y + cursorOffsetPoint.Y);
                SignIn.Location = this.Location;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePress = false;
            _clickPoint = Point.Empty;
            SignIn.Location = this.Location;
        }
    }
}
