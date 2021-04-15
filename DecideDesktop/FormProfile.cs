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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }
        public static ViewMain ViewMain;
        private void label1_Click(object sender, EventArgs e)
        {
            if(comboBoxChoiseCurrency.SelectedItem.Equals("BTC"))
            {
                Panel BTCpanel = new Panel();
                BTCpanel.Dock = DockStyle.Top;
                BTCpanel.Size = new Size(712, 40);
                panelFill.Controls.Add(BTCpanel);
               // ViewMain.Visible = false;
                Label BTC = new Label();
                
                BTC.Left = 30;

                BTC.Top = 10;
                BTC.Text = "BTC";
                BTC.ForeColor = Color.White;
                BTCpanel.Controls.Add(BTC);

                Label BTCamount = new Label(){
                    Location = new System.Drawing.Point(),
                };
                BTCamount.Left = 0;
                BTCamount.Top = 10;
                BTCamount.Text = "AMOUNT";
                BTCamount.ForeColor = Color.White;
                BTCpanel.Controls.Add(BTCamount);

                Label BTCpercent = new Label();
                BTCpercent.Left = 90;
                BTCpercent.Top = 10;
                BTCpercent.Text = "PERCENT";
                BTCpercent.ForeColor = Color.White;
                BTCpanel.Controls.Add(BTCpercent);
            }
            if (comboBoxChoiseCurrency.SelectedItem.Equals("ETH"))
            {

            }
            if (comboBoxChoiseCurrency.SelectedItem.Equals("LTC"))
            {


            }
            if (comboBoxChoiseCurrency.SelectedItem.Equals("BTC"))
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
    }
}
