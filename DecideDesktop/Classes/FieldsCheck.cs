using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecideDesktop.Classes
{
    public static class FieldsCheck
    {
        public static bool PasswordCheck(string text)
        {
            if (!text.Equals(""))
            {
                if (text.Length >= 8 && text.Length <= 16)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] < 48 || text[i] > 57 && text[i] < 65 || text[i] > 90 && text[i] < 97 || text[i] > 122)
                        {
                            return false;

                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool EMailCheck(string text)
        {
            if (!text.Equals(""))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if ((text[i] < 33 || text[i] > 122))
                    {
                        return false;
                    }
                    if (text[i] == '@')
                    {
                        for (int j = i; j < text.Length; j++)
                        {
                            if ((text[j] < 33 || text[j] > 122))
                            {
                                return false;
                            }
                            if (text[j] == '.')
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
                return false;

            }
            else
            {
                return false;
            }
        }
        public static bool UserNameCheck(string text)
        {
            if (!text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
