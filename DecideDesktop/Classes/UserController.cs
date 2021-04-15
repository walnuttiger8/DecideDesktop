using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecideDesktop.Classes
{
    internal static class UserController
    {
        internal static int SignUp(string Address, Dictionary<string, object> UserValues)
        {
            var JsonResult = HTTPClient.SendRequest(Address + "/register", UserValues);

            var userData = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                int userId = Convert.ToInt32(userData["user_id"]);
                return userId;
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return 0;
            }
        }
        internal static int LogIn(string Address, Dictionary<string, object> UserValues)
        {
            var JsonResult = HTTPClient.SendRequest(Address + "/login", UserValues);

            var userData = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                int userId = Convert.ToInt32(userData["user_id"]);
                return userId;
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return 0;
            }
        }

        internal static User GetUser(string Address, int userId)
        {
            Dictionary<string, object> userIdData = new Dictionary<string, object>
            {
                {"user_id", userId }
            };

            var JsonResult = HTTPClient.SendRequest(Address + "/get_user", userIdData);

            var UserData = JsonConvert.DeserializeObject<IDictionary<string, object>>(JsonResult["result"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                var thisUserUsername = UserData["Name"].ToString();
                var thisUserEmail = UserData["Email"].ToString();
                float thisUserBalance = float.Parse(UserData["Balance"].ToString());

                return new User(thisUserUsername, thisUserEmail, thisUserBalance);
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return null;
            }
        }

        internal static List<Wallet> GetWallets(string Address, int userId)
        {
            List<Wallet> UserWallets = null;
            Dictionary<string, object> userIdData = new Dictionary<string, object>
            {
                {"user_id", userId }
            };

            var JsonResult = HTTPClient.SendRequest(Address + "/get_wallets", userIdData);

            var WalletsList = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                foreach (Dictionary<string, object> Dictionary in WalletsList)
                {
                    var CoinParams = JsonConvert.DeserializeObject<Dictionary<string, object>>(Dictionary["Coin"].ToString());

                    Coin WalletCoin = new Coin(CoinParams["Symbol"].ToString(), float.Parse(CoinParams["Price"].ToString()));

                    var WalletAmount = float.Parse(Dictionary["Amount"].ToString());
                    var WalletPercent = float.Parse(Dictionary["Percent"].ToString());

                    UserWallets.Add(new Wallet(WalletCoin, WalletAmount, WalletPercent));
                }
                return UserWallets;
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return null;
            }
        }

        internal static Wallet GetCoin(string Address, string Symbol)
        {
            Dictionary<string, object> symbolData = new Dictionary<string, object>
            {
                {"symbol", Symbol}
            };

            var JsonResult = HTTPClient.SendRequest(Address + "/get_wallet", symbolData);

            var Wallet = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                var CoinParams = JsonConvert.DeserializeObject<Dictionary<string, object>>(Wallet["Coin"].ToString());

                Coin WalletCoin = new Coin(CoinParams["Symbol"].ToString(), float.Parse(CoinParams["Price"].ToString()));

                var WalletAmount = float.Parse(Wallet["Amount"].ToString());
                var WalletPercent = float.Parse(Wallet["Percent"].ToString());

                return new Wallet(WalletCoin, WalletAmount, WalletPercent);
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return null;
            }
        }

        internal static void PrintError(string ErrorMessage)
        {
            MessageBox.Show($"Сообщение: {ErrorMessage}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
