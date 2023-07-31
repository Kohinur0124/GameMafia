using GameMafia.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Models
{
    public class Message : MessageAbs
    {
        [Key]
        public int MessageId { get; set; }

       /* public int PlayerId { get; set; }

        public string MessagePlayer { get; set; }

        public DateTime DTime { get; set; }*/


        public Player Player { get; set; }
    }
}
