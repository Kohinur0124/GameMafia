using GameMafia.Core.Abstract;
using GameMafia.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Models
{
    public class Player : PlayerAbs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerId { get; set; }

        public int UserId { get; set; }

        public int? RoleId { get; set; }

        public DayNight? DeathDate { get; set; }

        public int Heal { get; set; } = 0;

        public int Count { get; set; } = 0;


        public ICollection<Message> Messages { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
