using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Interface
{
    public  interface  IUser
    {
        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int Summ { get; set; }

        public int Security { get; set; }
    }
}
