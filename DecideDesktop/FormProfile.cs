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
            try
            {
                if (comboBoxChoiseCurrency.SelectedItem.Equals("BTC"))
                {
                    var BTCPanel = createWallet(new Wallet(new Coin("BTC", 64000), 0.0150f, 25));
                    BTCPanel.Name = "BTCPanel";
                    WalletsPanel.Add(BTCPanel);
                    comboBoxChoiseCurrency.Items.Remove("BTC");
                }
                else if (comboBoxChoiseCurrency.SelectedItem.Equals("ETH"))
                {
                    var ETHPanel = createWallet(new Wallet(new Coin("ETH", 64000), 0.0150f, 25));
                    ETHPanel.Name = "ETHPanel";
                    WalletsPanel.Add(ETHPanel);
                    comboBoxChoiseCurrency.Items.Remove("ETH");
                }
                else if (comboBoxChoiseCurrency.SelectedItem.Equals("LTC"))
                {
                    var LTCPanel = createWallet(new Wallet(new Coin("LTC", 64000), 0.0150f, 25));
                    LTCPanel.Name = "LTCPanel";
                    WalletsPanel.Add(LTCPanel);
                    comboBoxChoiseCurrency.Items.Remove("LTC");
                }
                else if (comboBoxChoiseCurrency.SelectedItem.Equals("XRP"))
                {
                    var XRPPanel = createWallet(new Wallet(new Coin("XRP", 64000), 0.0150f, 25));
                    XRPPanel.Name = "XRPPanel";
                    WalletsPanel.Add(XRPPanel);
                    comboBoxChoiseCurrency.Items.Remove("XRP");
                }
            }
            catch
            {

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

    }
}
