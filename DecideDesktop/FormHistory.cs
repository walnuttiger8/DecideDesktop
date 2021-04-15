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
        public FormHistory()
        {
            InitializeComponent();
        }
        

        private void comboBoxChoiseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoiseCurrency.SelectedItem.Equals("BTC"))
            {
                var panel = createHistoryPanel(new Trade(new Wallet(new Coin("BTC", 64000), 0.015f, 25), 64000, 0.015f, "24/05/2021 20:25", "sell"));
                //var BTCPanel = createWallet(new Wallet(new Coin("BTC", 64000), 0.0150f, 25));
                //BTCPanel.Name = "BTCPanel";
                //HistoryPanel.Add(BTCPanel);
                
            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("ETH"))
            {
                var panel = createHistoryPanel(new Trade(new Wallet(new Coin("BTC", 64000), 0.015f, 25), 64000, 0.015f, "24/05/2021 20:25", "buy"));

                //var ETHPanel = createWallet(new Wallet(new Coin("ETH", 64000), 0.0150f, 25));
                //ETHPanel.Name = "ETHPanel";
                //HistoryPanel.Add(ETHPanel);

            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("LTC"))
            {
                //var LTCPanel = createWallet(new Wallet(new Coin("LTC", 64000), 0.0150f, 25));
                //LTCPanel.Name = "LTCPanel";
                //HistoryPanel.Add(LTCPanel);
              
            }
            else if (comboBoxChoiseCurrency.SelectedItem.Equals("XRP"))
            {
                //var XRPPanel = createWallet(new Wallet(new Coin("XRP", 64000), 0.0150f, 25));
                //XRPPanel.Name = "XRPPanel";
                //HistoryPanel.Add(XRPPanel);
                
            }
            else if(comboBoxChoiseCurrency.SelectedItem.Equals("Все валюты"))
            {

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
                Text = trade.Wallet.Coin.Symbol.ToString(),
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
                Size = new Size(670, 1),
                Top = 39,
                Left = 20
            };
            panelLine.BackColor = Color.White;
            panel.Controls.Add(panelLine);
            return panel;
        }

    }
}

