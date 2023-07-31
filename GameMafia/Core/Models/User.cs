using GameMafia.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Models
{
    public class User :UserAbs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

       /* public string FullName { get; set; }

        public string UserName { get; set; } 

        public string Password { get; set; }

      

        public int Summ { get; set; } = 0;

        public int Security { get; set; } = 0;*/
       

        public ICollection<Player> Players { get; set; }
    }

}
