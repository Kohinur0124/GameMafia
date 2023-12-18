using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.MafiaModels.Interface
{
    public interface IMessage<T>
    {
        public string connectionString { get; set; } 

        public List<T> Gets();
        public void Update(T message);
        public void Delete(T message);
        public void Create(T message);
    }
}
