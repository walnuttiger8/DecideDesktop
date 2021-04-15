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

            var UserData = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["result"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                return User.FromJson(UserData);
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
                    Wallet wallet = Wallet.FromJson(Dictionary);

                    UserWallets.Add(wallet);
                }
                return UserWallets;
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return null;
            }
        }

        internal static Wallet GetWallet(string Address, string Symbol, int userId)
        {
            Dictionary<string, object> UserDict = new Dictionary<string, object>()
            {
                {"symbol", Symbol },
                {"user_id", userId}
            };

            var JsonResult = HTTPClient.SendRequest(Address + "/get_wallet", UserDict);

            var wallet = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                return Wallet.FromJson(wallet);
            }
            else
            {
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

            var WalletDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                Wallet wallet = Wallet.FromJson(WalletDict);
                return wallet;
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return null;
            }
        }

        internal static Wallet AddCoin(string Address, string Symbol, int userId)
        {
            Dictionary<string, object> UserCoin = new Dictionary<string, object>()
            {
                {"symbol", Symbol },
                {"user_id", userId }
            };

            var JsonResult = HTTPClient.SendRequest(Address + "/add_coin", UserCoin);

            var WalletDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                Wallet wallet = Wallet.FromJson(WalletDict);
                return wallet;
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return null;
            }
        }

        internal static List<Trade> GetTrades(string Address, int userId)
        {
            List<Trade> TradesList = null;
            Dictionary<string, object> userIdDict = new Dictionary<string, object>()
            {
                {"user_id" , userId }
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/get_trades", userIdDict);

            var Trades = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                foreach (Dictionary<string, object> Dictionary in Trades)
                {
                    Trade trade = Trade.FromJson(Dictionary);
                    TradesList.Add(trade);
                }
                return TradesList;
            }
            else
            {
                PrintError(JsonResult["success"].ToString());
                return null;
            }
        }

        internal static string IncreaseBalance(string Address, int userId)
        {
            Dictionary<string, object> userIdDict = new Dictionary<string, object>()
            {
                {"user_id", userId }
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/top_up", userIdDict);

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                return "Баланс пополнен успешно";
            }
            else
            {
                return null;
            }
        }

        internal static List<float> GetChartData(string Address, string Symbol)
        {
            List<float> ChartData = null;
            Dictionary<string, object> CoinDict = new Dictionary<string, object>()
            {
                {"symbol", Symbol }
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/get_chart_data", CoinDict);

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {            
                return ChartData = JsonConvert.DeserializeObject<List<float>>(JsonResult["results"].ToString());
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
