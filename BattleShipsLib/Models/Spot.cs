using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsLib.Models
{
    public class Spot
    {
        public int X { get; set; }
        public int Y { get; set; }
        

        public enum Status
        {
            Unkown,
            Hit,
            Sunk
        }

    }
}
