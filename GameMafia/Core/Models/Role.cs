using GameMafia.Core.Abstract;
using GameMafia.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Models
{
    public class Role : RoleAbs
    {
        [Key]
        public int RoleId { get; set; }
/*
        public string Name { get; set; }

        public string Description { get; set; }

        public RoleType Type { get; set; }*/

        public ICollection<CountRole> CountRole { get; set;}
        public ICollection<Player> Players { get; set;}
    }
}
