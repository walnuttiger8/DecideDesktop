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
    public partial class FormHistory : Form
    {
        internal static List<Panel> HistoryPanel = new List<Panel>();
        internal static List<Trade> Trades = new List<Trade>();
        public FormHistory()
        {
            InitializeComponent();
        }
        

        private void comboBoxChoiseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearPanelList();
            labelTransactionHavent.Text = "Отсутствуют транзакции с выбранным кошельком";
            if (comboBoxChoiseCurrency.SelectedItem.Equals("BTCUSDT"))
            {
                List<Trade> BTCTrades = SortTrade("BTCUSDT");
                if (BTCTrades.Count != 0)
                {
                    foreach (Trade trade in BTCTrades)
                    {
                        var panel = createHistoryPanel(trade);
                    }
                }
                else
                {
                    labelTransactionHavent.Visible = true;
                }
                //var BTCPanel = createWallet(new Wallet(new Coin("BTC", 64000), 0.0150f, 25));
                //BTCPanel.Name = "BTCPanel";
                //HistoryPanel.Add(BTCPanel);

            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("ETHUSDT"))
            {
                List<Trade> ETHTrades = SortTrade("ETHUSDT");
                if (ETHTrades.Count != 0)
                {
                    foreach (Trade trade in ETHTrades)
                    {
                        var panel = createHistoryPanel(trade);
                    }
                }
                else
                {
                    labelTransactionHavent.Visible = true;
                }

                //var ETHPanel = createWallet(new Wallet(new Coin("ETH", 64000), 0.0150f, 25));
                //ETHPanel.Name = "ETHPanel";
                //HistoryPanel.Add(ETHPanel);

            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("LTCUSDT"))
            {
                List<Trade> LTCTrades = SortTrade("LTCUSDT");
                if (LTCTrades.Count != 0)
                {
                    foreach (Trade trade in LTCTrades)
                    {
                        var panel = createHistoryPanel(trade);
                    }
                }
                else
                {
                    labelTransactionHavent.Visible = true;
                }
                //var LTCPanel = createWallet(new Wallet(new Coin("LTC", 64000), 0.0150f, 25));
                //LTCPanel.Name = "LTCPanel";
                //HistoryPanel.Add(LTCPanel);

            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("XRPUSDT"))
            {
                List<Trade> XRPTrades = SortTrade("XRPUSDT");
                if (XRPTrades.Count != 0)
                {
                    foreach (Trade trade in XRPTrades)
                    {
                        var panel = createHistoryPanel(trade);
                    }
                }
                else
                {
                    labelTransactionHavent.Visible = true;
                }
                //var XRPPanel = createWallet(new Wallet(new Coin("XRP", 64000), 0.0150f, 25));
                //XRPPanel.Name = "XRPPanel";
                //HistoryPanel.Add(XRPPanel);

            }
            else if(comboBoxChoiseCurrency.SelectedItem.Equals("Все валюты"))
            {
                if (Trades.Count != 0)
                {
                    foreach (Trade trade in Trades)
                    {
                        var panel = createHistoryPanel(trade);
                    }
                }
                else
                {
                    labelTransactionHavent.Visible = true;
                }
            }
        }
        internal Panel createHistoryPanel(Trade trade)
        {
            labelTransactionHavent.Visible = false;
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Size = new Size(712, 40);
            panelFillHistory.Controls.Add(panel);

            Label Coin = new Label()
            {
                Location = new System.Drawing.Point(60, 10),
                Text = trade.Symbol.ToString(),
                Font = new System.Drawing.Font("Monsterrat", 14.0f),
            };
            Coin.Left = 30;
            Coin.Top = 10;
            Coin.ForeColor = Color.White;
            panel.Controls.Add(Coin);
            
            Label amount = new Label()
            {
                Location = new System.Drawing.Point(60, 10),
                Text = trade.Amount.ToString(),
                Font = new System.Drawing.Font("Monsterrat", 14.0f),

            };
            amount.Left = 180;
            amount.Top = 10;
            amount.ForeColor = Color.White;
            panel.Controls.Add(amount);

            Label Balance = new Label()
            {
                Size = new Size(150, 28),
                Location = new System.Drawing.Point(60, 10),
                Font = new System.Drawing.Font("Arial", 14.0f),
                Left = 380,
                Top = 10
            };
            if(trade.Transaction=="sell")
            {
                Balance.Text = "-" + (trade.Price * trade.Amount) + "$";
                Balance.ForeColor = Color.IndianRed;
            }
            if (trade.Transaction == "buy")
            {
                Balance.Text = "+" + (trade.Price * trade.Amount) + "$";
                Balance.ForeColor = Color.LightGreen;
            }

            panel.Controls.Add(Balance);

            Label labelTime = new Label()
            {
                Size = new Size(300,28),
                Location = new System.Drawing.Point(60, 10),
                Text = trade.Time,
                Font = new System.Drawing.Font("Monsterrat", 14.0f),
                Top = 10,
                Left = 550,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            
            panel.Controls.Add(labelTime);


            Panel panelLine = new Panel()
            {
                Size = new Size(815, 1),
                Top = 39,
                Left = 20
            };
            panelLine.BackColor = Color.White;
            panel.Controls.Add(panelLine);
            HistoryPanel.Add(panel);
            return panel;
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            comboBoxChoiseCurrency.SelectedIndex = 0;

            Trades = UserController.GetTrades(ViewMain.userId);
            List<Wallet> wallets = UserController.GetWallets(ViewMain.userId);

            if (wallets.Count != 0)
            {
                foreach (Wallet wallet in wallets)
                {
                    comboBoxChoiseCurrency.Items.Add(wallet.Coin.Symbol);
                }
            }

            if (Trades.Count != 0)
            {
                foreach (Trade trade in Trades)
                {
                    var panel = createHistoryPanel(trade);
                }
            }
            else
            {
                labelTransactionHavent.Visible = true;
            }
        }

        internal List<Trade> SortTrade(string Symbol)
        {
            List<Trade> SortedTrades = new List<Trade>();

            foreach (Trade trade in Trades)
            {
                if (trade.Symbol == Symbol)
                {
                    SortedTrades.Add(trade);
                }
            }

            return SortedTrades;
        }

        internal void ClearPanelList()
        {
            foreach(Panel panel in HistoryPanel)
            {
                panel.Dispose();
            }
            HistoryPanel.Clear();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panelFillHistory.Left += 10;
        }

        private void panelFillHistory_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

