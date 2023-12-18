using GameMafia.Core.MafiaModels.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.MafiaModels.Models
{
    public class ChatMessage 
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string DayNight { get; set; }

        public string RoleName { get; set; }

        public List<ChatMessage> Gets()
        {
            var chs = new ChatService();
            return chs.Gets();
        } 
    }
}
