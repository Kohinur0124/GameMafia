using GameMafia.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GameMafia.Services
{
    public static class CheckRegister
    {
        public static bool PasswordChecked(string password)
        {
            Regex PasswordRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*_-]).{8,}$");
            if (PasswordRegex.IsMatch(password))
            {
                return true;
            }
            return false;
        }

        public static bool CheckUserName(string username) 
        {
            Regex UsernameRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*_-]).{8,}$");
            if (UsernameRegex.IsMatch(username))
            {
                    return true;   
            }
            return false;

        }
        public static bool CheckFullName(string fullname) 
        {
            Regex FullnameRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[ ]).{8,}$");
            if (FullnameRegex.IsMatch(fullname))
            {
                return true;
            }
            return false;
        }

    }
}
