using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.MafiaModels.Models
{
    public class GroupMessage
    {
        public int GroupMessageId { get; set; }
        public string Message { get; set; }

        public List<GroupMessage> Gets()
        {
            var gs = new GroupMessage();
            return gs.Gets();
        }
    }
}
