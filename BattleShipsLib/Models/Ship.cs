using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsLib.Models
{
    internal class Ship
    {
        public  Spot? Position { get; set; }
        public bool ShipDestoryed { get; set; }

    }
}
