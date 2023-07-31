using GameMafia.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Abstract
{
    public abstract class UserAbs : IUser
    {
        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }


        public int Summ { get; set; } = 0;

        public int Security { get; set; } = 0;
    }
}
