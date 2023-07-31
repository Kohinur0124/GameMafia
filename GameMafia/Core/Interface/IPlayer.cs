using GameMafia.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Interface
{
    public interface  IPlayer
    {
        public int UserId { get; set; }

        public int? RoleId { get; set; }

        public DayNight? DeathDate { get; set; }

        public int Heal { get; set; }

        public int Count { get; set; }
    }
}
