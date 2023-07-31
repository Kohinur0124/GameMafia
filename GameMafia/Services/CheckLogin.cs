using GameMafia.Core.Data;
using GameMafia.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GameMafia.Services
{
    public static class CheckLogin
    { 
        public static bool CheckUsername( string username)
        {
            if (CheckRegister.CheckUserName(username) )
            {
                var db = new MafiaGameDb();
                var user = db.Users.FirstOrDefault(user => user.UserName == username);
                if (user != null)
                {
                    if( user.UserName == username ) 
                    { 
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        
        public static bool CheckPassword( string password , string username)
        {
            if (CheckRegister.PasswordChecked(password))
            {
                var db = new MafiaGameDb();
                var user = db.Users.FirstOrDefault(user => user.UserName == username );
                if (user.Password == password)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static User? GetUser( string username)
        {
            var db = new MafiaGameDb();
            var user = db.Users.FirstOrDefault(user => user.UserName == username);
            return user;

        }
    }

}
