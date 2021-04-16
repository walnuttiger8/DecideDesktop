using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecideDesktop.Classes
{
    internal class Wallet
    {
        internal static FormProfile FormProfile;
        internal Coin Coin { get; set; }
        internal float Amount { get; set; }
        internal float Percent { get; set; }

        public Wallet(Coin Coin, float Amount, float Percent)
        {
            this.Coin = Coin;
            this.Amount = Amount;
            this.Percent = Percent;
        }
        internal void Sell(object sender, EventArgs e)
        {
            var Submit = MessageBox.Show("Вы точно хотите продать всю валюту с выбранного кошелька?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Submit == DialogResult.Yes)
            {
                if (this.Amount != 0)
                {
                    UserController.Sell(this.Coin.Symbol, ViewMain.userId);
                    FormProfile.UpdateWallets();
                }
                else
                {
                    MessageBox.Show("Сделка не удалась: нечего продавать", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        internal static Wallet FromJson(Dictionary<string, object> JsonResult)
        {
            Coin coin = Coin.FromJson(JsonResult["coin"].ToString());

            return new Wallet(coin, float.Parse(JsonResult["amount"].ToString()), float.Parse(JsonResult["percent"].ToString()));
        }
    }
}
