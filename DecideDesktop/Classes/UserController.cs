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
        internal static int SignUp(Dictionary<string, object> UserValues)
        {
            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/register", UserValues);

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
        internal static int LogIn(Dictionary<string, object> UserValues)
        {
            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/login", UserValues);

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

        internal static User GetUser(int userId)
        {
            Dictionary<string, object> userIdData = new Dictionary<string, object>
            {
                {"user_id", userId }
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/get_user", userIdData);

            var UserData = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                User user = User.FromJson(UserData);
                return user;
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return null;
            }
        }

        internal static List<Wallet> GetWallets(int userId)
        {
            List<Wallet> UserWallets = new List<Wallet>();
            Dictionary<string, object> userIdData = new Dictionary<string, object>
            {
                {"user_id", userId }
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/get_wallets", userIdData);

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

        internal static Wallet GetWallet(string Symbol, int userId)
        {
            Dictionary<string, object> UserDict = new Dictionary<string, object>()
            {
                {"symbol", Symbol },
                {"user_id", userId}
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/get_wallet", UserDict);

            var WalletDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                Wallet wallet = Wallet.FromJson(WalletDict);
                return wallet;
            }
            else
            {
                return null;
            }
        }

        internal static Wallet GetCoin(string Symbol)
        {
            Dictionary<string, object> symbolData = new Dictionary<string, object>
            {
                {"symbol", Symbol}
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/get_wallet", symbolData);

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

        internal static Wallet AddCoin(string Symbol, int userId, float percent = 100)
        {
            Dictionary<string, object> UserCoin = new Dictionary<string, object>()
            {
                {"symbol", Symbol },
                {"user_id", userId },
                {"percent", percent }
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/add_coin", UserCoin);

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

        internal static List<Trade> GetTrades(int userId)
        {
            List<Trade> TradesList = new List<Trade>();
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

        internal static float IncreaseBalance(int userId, float amount)
        {
            Dictionary<string, object> userIdDict = new Dictionary<string, object>()
            {
                {"user_id", userId },
                {"amount", amount }
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/top_up", userIdDict);

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                return float.Parse(JsonResult["results"].ToString());
            }
            else
            {
                return 0;
            }
        }

        internal static float GetOverallBalance(int userId)
        {
            Dictionary<string, object> userIdDict = new Dictionary<string, object>()
            {
                {"user_id", userId }
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/overall_balance", userIdDict);

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                return float.Parse(JsonResult["results"].ToString());
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return 0;
            }
        }

        internal static Trade Sell(string Symbol, int userId)
        {
            Dictionary<string, object> CoinDict = new Dictionary<string, object>()
            {
                {"symbol", Symbol },
                {"user_id", userId }
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/sell", CoinDict);

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                return Trade.FromJson((Dictionary<string, object>)JsonResult["results"]);
            }
            else
            {
                PrintError(JsonResult["message"].ToString());
                return null;
            }
        }

        internal static List<float> GetChartData(string Symbol, string interval = "1h", int limit = 10)
        {
            List<float> ChartData = new List<float>();
            Dictionary<string, object> CoinDict = new Dictionary<string, object>()
            {
                {"symbol", Symbol },
                {"interval", interval },
                {"limit", limit }
            };

            var JsonResult = HTTPClient.SendRequest(HTTPClient.Address + "/get_history", CoinDict);

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
