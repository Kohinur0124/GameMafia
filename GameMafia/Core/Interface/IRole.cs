using GameMafia.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Interface
{
    public interface IRole
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public RoleType Type { get; set; }
    }
}
