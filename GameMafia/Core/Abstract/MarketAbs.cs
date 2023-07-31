using GameMafia.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Abstract
{
    public abstract class MarketAbs : IMarkent
    {

        public string Name { get; set; }

        public int Price { get; set; }

    }
}
