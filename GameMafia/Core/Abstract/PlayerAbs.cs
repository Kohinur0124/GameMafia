using GameMafia.Core.Enum;
using GameMafia.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Abstract
{
    public abstract class PlayerAbs : IPlayer
    {
        public int UserId { get; set; }

        public int? RoleId { get; set; }

        public DayNight? DeathDate { get; set; }

        public int Heal { get; set; } = 0;

        public int Count { get; set; } = 0;
    }
}
