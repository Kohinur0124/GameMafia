using GameMafia.Core.Enum;
using GameMafia.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Abstract
{
    public abstract class RoleAbs : IRole
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public RoleType Type { get; set; }
    }
}
