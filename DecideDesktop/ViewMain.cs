using DecideDesktop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecideDesktop
{
    public partial class ViewMain : Form
    {
        public static ViewSignIn SignIn = new ViewSignIn();
        public static ViewSignUp SignUp = new ViewSignUp();
        public static FormMain FormMain;
        internal static List<float> ETHGraphic = new List<float>();
        internal static List<float> BTCGraphic = new List<float>();
        internal static List<float> LTCGraphic = new List<float>();
        internal static List<float> XRPGraphic = new List<float>();
        internal static int userId;
        internal static User thisUser;
        public ViewMain()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        internal void CustomizeDesign()
        {
            panelMenuSubmenu.Visible = false;
            panelCurrencySubmenu.Visible = false;
        }
        internal void hideSubMenu()
        {
            if (panelMenuSubmenu.Visible == true)
                panelMenuSubmenu.Visible = false;
            if (panelCurrencySubmenu.Visible == true)
                panelCurrencySubmenu.Visible = false;
        }
        internal void showSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible==false)
            {
                //hideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void btmMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMain());
            FormMain.FormMainGraphic.GraphicsDraw(BTCGraphic);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProfile());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHistory());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSettings());  
        }
        
        private void btnCurrency_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCurrencySubmenu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMain());
            FormMain.FormMainGraphic.GraphicsDraw(BTCGraphic);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMain());
            FormMain.FormMainGraphic.GraphicsDraw(ETHGraphic);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMain());
            FormMain.FormMainGraphic.GraphicsDraw(LTCGraphic);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            SignUp.Visible = true;
            SignIn.Visible = true;
            this.Dispose();          
        }

        private void btmMenu_MouseMove(object sender, MouseEventArgs e)
        {
            btmMenu.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            btnMainView.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            btnProfileView.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            btnHistoryView.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            btnSettingsView.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void btnCurrency_MouseMove(object sender, MouseEventArgs e)
        {
            btnCurrency.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            btnBTCcurrency.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            btnETHcurrency.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            btnLTCcurrency.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void btmMenu_MouseLeave(object sender, EventArgs e)
        {
            btmMenu.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnMainView.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnProfileView.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnHistoryView.ForeColor = Color.White;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            btnSettingsView.ForeColor = Color.White;
        }

        private void btnCurrency_MouseLeave(object sender, EventArgs e)
        {
            btnCurrency.ForeColor = Color.White;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            btnBTCcurrency.ForeColor = Color.White;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            btnETHcurrency.ForeColor = Color.White;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            btnLTCcurrency.ForeColor = Color.White;
        }

        private void picExit_MouseMove(object sender, MouseEventArgs e)
        {
            picExit.BackgroundImage = Properties.Resources.exit_yellow;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Properties.Resources.exit_grey;
        }

        List<Label> Coints;
        List<Label> Prices;

        private void ViewMain_Load(object sender, EventArgs e)
        {
            timer1.Start();

            Coints = new List<Label>()
            {
                labelConstBTC,labelConstETH,labelConstLTC,labelConstXRP
            };
            Prices = new List<Label>()
            {
                labelConstBTCPrice,labelConstETHPrice,labelConstLTCPrice,labelConstXRPPrice
            };

            if (userId != 0)
            {
                labelUsername.Text = thisUser.Name;
            }

            openChildForm(new FormMain());
            showSubMenu(panelMenuSubmenu);
            showSubMenu(panelCurrencySubmenu);
            FormMain.FormMainGraphic.GraphicsDraw(BTCGraphic);
            FormProfile.ViewMain = this;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFill.Controls.Add(childForm);
            panelFill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ViewMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите покинуть приложение?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
                e.Cancel = false;
            else
                e.Cancel = true;
            
        }

        private void ViewMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnXRP_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMain());
            FormMain.FormMainGraphic.GraphicsDraw(XRPGraphic);
        }

        private void btnXRP_MouseMove(object sender, MouseEventArgs e)
        {
            btnXRP.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void btnXRP_MouseLeave(object sender, EventArgs e)
        {
            btnXRP.ForeColor = Color.White;
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread receiveThread = new Thread(new ThreadStart(UpdatePanel));
            receiveThread.Start(); //старт потока
            
        }
        private void UpdatePanel()
        {
            for (int i = 0; i < Coints.Count; i++)
            {
                String symbol = Coints[i].Text;
                Coin coin = UserController.GetCoin(symbol + "USDT");
                string price = Prices[i].Text.Replace('.', ',');
                price = price.Replace('↓', ' ');
                price = price.Replace('↑', ' ');
                if (price == "")
                {
                    return;
                }
                try
                {
                    if (float.Parse(price) > coin.Price)
                    {
                        //↓ ↑

                        Prices[i].Invoke(new Action(() => Prices[i].ForeColor = Color.IndianRed));
                        Prices[i].Invoke(new Action(() => Prices[i].Text = "↓ " + coin.Price));
                    }
                    if (float.Parse(price) < coin.Price)
                    {
                        //↓ ↑

                        Prices[i].Invoke(new Action(() => Prices[i].ForeColor = Color.LightGreen));
                        Prices[i].Invoke(new Action(() => Prices[i].Text = "↑ " + coin.Price));
                    }
                }
                catch (Exception e)
                {
                    return;
                }
            }
        }
    }
}
