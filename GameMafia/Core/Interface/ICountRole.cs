using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Interface
{
    public interface ICountRole
    {
        public int CountPlayer { get; set; }

        public int RoleId { get; set; }

        public int CountRoles { get; set; }
    }
}
