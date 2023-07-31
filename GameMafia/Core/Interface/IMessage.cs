using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Interface
{
    public interface IMessage 
    {
        public int PlayerId { get; set; }

        public string MessagePlayer { get; set; }

        public DateTime DTime { get; set; }
    }
}
