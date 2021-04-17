﻿using System;
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
            if (comboBoxChoiseCurrency.Items.Count == 0 || comboBoxChoiseCurrency.SelectedItem == null)
            {

            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("BTCUSDT"))
            {
                var BTCPanel = createWallet(UserController.AddCoin("BTCUSDT", ViewMain.userId));
                BTCPanel.Name = "BTCPanel";
                comboBoxChoiseCurrency.Items.Remove("BTCUSDT");
            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("ETHUSDT"))
            {
                var ETHPanel = createWallet(UserController.AddCoin("ETHUSDT", ViewMain.userId));
                ETHPanel.Name = "ETHPanel";
                comboBoxChoiseCurrency.Items.Remove("ETHUSDT");
            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("LTCUSDT"))
            {
                var LTCPanel = createWallet(UserController.AddCoin("LTCUSDT", ViewMain.userId));
                LTCPanel.Name = "LTCPanel";
                comboBoxChoiseCurrency.Items.Remove("LTCUSDT");
            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("XRPUSDT"))
            {
                var XRPPanel = createWallet(UserController.AddCoin("XRPUSDT", ViewMain.userId));
                XRPPanel.Name = "LTCPanel";
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
            BTCamount.Left = 180;
            BTCamount.Top = 10;
            BTCamount.ForeColor = Color.White;
            panel.Controls.Add(BTCamount);

            Label price = new Label()
            {
                Location = new System.Drawing.Point(60, 10),
                Text = (wallet.Amount * wallet.Coin.Price) + "$",
                Font = new System.Drawing.Font("Monsterrat", 14.0f),
            };
            price.Left = 370;
            price.Top = 10;
            price.ForeColor = Color.LightGreen;
            panel.Controls.Add(price);

            Label BTCpercent = new Label()
            {
                Location = new System.Drawing.Point(60, 10),
                Text = wallet.Percent.ToString() + " %",
                Font = new System.Drawing.Font("Monsterrat", 14.0f),
                Left = 560,
                Top = 10,
                ForeColor = Color.White,
            };
            panel.Controls.Add(BTCpercent);

            Label labelSell = new Label()
            {
                Size = new Size(20, 28),
                Text = "X",
                Font = new System.Drawing.Font("Arial", 18.0f),
                Top = 10,
                Left = 720,
                ForeColor = Color.Red,
                FlatStyle = FlatStyle.Flat       
            };
            labelSell.Click += new EventHandler(wallet.Sell);
            panel.Controls.Add(labelSell);

            Panel panelLine = new Panel()
            {
                Size = new Size(700, 1),
                Top = 39,
                Left = 20
            };
            panelLine.BackColor = Color.White;
            panel.Controls.Add(panelLine);
            WalletsPanel.Add(panel);
            return panel;
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            Wallet.FormProfile = this;
            UpdateWallets();
        }
       
        public void UpdateWallets()
        {
            if (comboBoxChoiseCurrency.Items.Count == 0)
            {
                comboBoxChoiseCurrency.Enabled = false;
            }
            foreach (Panel panel in WalletsPanel)
            {
                panel.Dispose();
            }
            WalletsPanel.Clear();
            List<Wallet> wallets = UserController.GetWallets(ViewMain.userId);
            if (wallets.Count != 0)
            {
                foreach (Wallet wallet in wallets)
                {
                    createWallet(wallet);
                    comboBoxChoiseCurrency.Items.Remove(wallet.Coin.Symbol);
                }
                ViewMain.thisUser = UserController.GetUser(ViewMain.userId);
                labelUserBalance.Text = $"Баланс: {ViewMain.thisUser.Balance}$";
            }
        }

        private void labelPercentQuestion_MouseMove(object sender, MouseEventArgs e)
        {
            labelQw.Text = "Процент от \nвашего баланса, использованный \nдля покупки валюты";
            labelPercentQuestion.Text = "";
            labelQw.ForeColor = Color.Yellow;

        }

        private void labelPercentQuestion_MouseLeave(object sender, EventArgs e)
        {
            labelQw.Text = "";
            labelPercentQuestion.Text = "?";
            labelPercentQuestion.ForeColor = Color.White;
        }
    }
}
