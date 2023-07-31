using GameMafia.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.Models
{
    public class Market : MarketAbs
    {
        [Key]
        public int MarketId { get; set; }
/*
        public string Name { get; set; }

        public int Price { get; set; }*/
    }
}
