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
    public partial class ViewSignIn : Form
    {
        public ViewSignIn()
        {
            InitializeComponent();
            this.MouseClick += panelLocation_MouseClick;
        }

        ViewSignUp SignUp = new ViewSignUp();

        private void buttonSignUpSignIn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int forTimer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            forTimer += 1;
            SignUp.Left += 10;
           
            if (forTimer == 36)
            {
                timer1.Stop();

                this.TopMost = false;
                SignUp.TopMost = true;
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            forTimer -= 1;
            SignUp.Left -= 10;
            if (forTimer == 0)
            {
                timer2.Stop();
            }

        }

        private void ViewSignIn_Load(object sender, EventArgs e)
        {
            ViewMain.SignIn = this;
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
            if (Classes.FieldsCheck.UserNameCheck(textBoxSignInProfile.Text) &&
                Classes.FieldsCheck.PasswordCheck(textBoxSignInPassword.Text))
            {
                Dictionary<string, object> SignInValues = new Dictionary<string, object>()
                {
                    { "email", textBoxSignInProfile.Text },
                    { "password", textBoxSignInPassword.Text}
                };

                int userId = UserController.LogIn(HTTPClient.Address, SignInValues);
                ViewMain.userId = userId;
                ViewMain.thisUser = UserController.GetUser(HTTPClient.Address, userId);

                ViewMain viewMain = new ViewMain();

                viewMain.Show();
                this.Visible = false;
                SignUp.Visible = false;           
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewMain m = new ViewMain();
            m.Show();
            this.Visible = false;
            SignUp.Visible = false;
        }

        private void panelLocation_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelLocation_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Location = new Point(Cursor.Position.X - ClientSize.Width / 2, Cursor.Position.Y - ClientSize.Height / 2);

        }
        private bool isMousePress = false;
        private Point _clickPoint;
        private Point _formStartPoint;
        private void panelLocation_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePress = true;
            _clickPoint = Cursor.Position;
            _formStartPoint = Location;
            SignUp.Location = this.Location;
        }

        private void panelLocation_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePress)
            {
                var cursorOffsetPoint = new Point( //считаем смещение курсора от старта
                    Cursor.Position.X - _clickPoint.X,
                    Cursor.Position.Y - _clickPoint.Y);

                Location = new Point( //смещаем форму от начальной позиции в соответствии со смещением курсора
                    _formStartPoint.X + cursorOffsetPoint.X,
                    _formStartPoint.Y + cursorOffsetPoint.Y);
                SignUp.Location = this.Location;
            }
        }

        private void panelLocation_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePress = false;
            _clickPoint = Point.Empty;
            SignUp.Location = this.Location;
        }
    }
}
