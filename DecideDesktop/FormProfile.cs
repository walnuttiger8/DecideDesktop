using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DecideDesktop.Classes;

namespace DecideDesktop
{
    public partial class FormProfile : Form
    {
        internal static List<Panel> WalletsPanel = new List<Panel>();
        public FormProfile()
        {
            InitializeComponent();
        }
        public static ViewMain ViewMain;
   
        private void label1_Click(object sender, EventArgs e)
        {

            if (comboBoxChoiseCurrency.SelectedItem.Equals("BTCUSDT"))
            {
                var BTCPanel = createWallet(UserController.AddCoin("BTCUSDT", ViewMain.userId));
                BTCPanel.Name = "BTCPanel";
                WalletsPanel.Add(BTCPanel);
                comboBoxChoiseCurrency.Items.Remove("BTCUSDT");
            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("ETHUSDT"))
            {
                var ETHPanel = createWallet(UserController.AddCoin("ETHUSDT", ViewMain.userId));
                ETHPanel.Name = "ETHPanel";
                WalletsPanel.Add(ETHPanel);
                comboBoxChoiseCurrency.Items.Remove("ETHUSDT");
            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("LTCUSDT"))
            {
                var LTCPanel = createWallet(UserController.AddCoin("LTCUSDT", ViewMain.userId));
                LTCPanel.Name = "LTCPanel";
                WalletsPanel.Add(LTCPanel);
                comboBoxChoiseCurrency.Items.Remove("LTCUSDT");
            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("XRPUSDT"))
            {
                var XRPPanel = createWallet(UserController.AddCoin("XRPUSDT", ViewMain.userId));
                XRPPanel.Name = "LTCPanel";
                WalletsPanel.Add(XRPPanel);
                comboBoxChoiseCurrency.Items.Remove("XRPUSDT");
            }            

        }

        private void labelAddCurrency_MouseMove(object sender, MouseEventArgs e)
        {
            labelAddCurrency.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void labelAddCurrency_MouseLeave(object sender, EventArgs e)
        {
            labelAddCurrency.ForeColor = Color.White;
        }
        internal Panel createWallet(Wallet wallet)
        {
            labelWalletHavent.Visible = false;
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Size = new Size(712, 40);
            panelFill.Controls.Add(panel);

            Label BTC = new Label()
            {
                Location = new System.Drawing.Point(60, 10),
                Text = wallet.Coin.Symbol.ToString(),
                Font = new System.Drawing.Font("Monsterrat", 14.0f),
            };
            BTC.Left = 30;
            BTC.Top = 10;
            BTC.ForeColor = Color.White;
            panel.Controls.Add(BTC);

            Label BTCamount = new Label()
            {
                Location = new System.Drawing.Point(60, 10),
                Text =wallet.Amount.ToString(),
                Font = new System.Drawing.Font("Monsterrat", 14.0f),
            };
            BTCamount.Left = 230;
            BTCamount.Top = 10;
            BTCamount.ForeColor = Color.White;
            panel.Controls.Add(BTCamount);

            Label BTCpercent = new Label()
            {
                Location = new System.Drawing.Point(60, 10),
                Text = wallet.Percent.ToString() + " %",
                Font = new System.Drawing.Font("Monsterrat", 14.0f),
                Left = 430,
                Top = 10,
                ForeColor = Color.White,
            };
            panel.Controls.Add(BTCpercent);

            Label labelSell = new Label()
            {
                Size = new Size(100, 30),
                Text = "X",
                Font = new System.Drawing.Font("Arial", 18.0f),
                Top = 10,
                Left = 550,
                ForeColor = Color.Red,
                FlatStyle = FlatStyle.Flat       
            };
            labelSell.Click+= new EventHandler(wallet.Sell);
            panel.Controls.Add(labelSell);

            Panel panelLine = new Panel()
            {
                Size = new Size(510, 1),
                Top = 39,
                Left = 20
            };
            panelLine.BackColor = Color.White;
            panel.Controls.Add(panelLine);
            return panel;
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            List<Wallet> wallets = UserController.GetWallets(ViewMain.userId);
            if (wallets.Count != 0)
            {
                foreach (Wallet wallet in wallets)
                {
                    createWallet(wallet);
                    comboBoxChoiseCurrency.Items.Remove(wallet.Coin.Symbol);
                }
            }
            labelUserBalance.Text += $" {ViewMain.thisUser.Balance}$";
        }
    }
}
