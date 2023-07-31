using GameMafia.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Abstract
{
    public abstract class MessageAbs : IMessage
    {
        public int PlayerId { get; set; }

        public string MessagePlayer { get; set; }

        public DateTime DTime { get; set; }
    }
}
