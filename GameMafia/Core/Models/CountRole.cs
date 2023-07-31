using GameMafia.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Models
{
    public class CountRole : CountRoleAbs
    {
        [Key]
        public int CountRoleId { get; set; }

        /*public int CountPlayer { get; set; }

        public int RoleId { get; set; }

        public int CountRoles { get; set; }*/

        public Role Role { get; set; }

    }
}
