using BattleShipsLib.GameLogic;
using BattleShipsLib.Logic;
using BattleShipsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsLib.Players
{ 
    public class Player
    {
        private int NoShips = 5;

        public string Name { get; set; }
        List<Ship> PlayerShips { get; set; } = new List<Ship>();
        public GameBoard PlayerBoard { get; set; } = new GameBoard();

        public Player(string name)
        {
            Name = name;
        }
 
        public void AddShip(int x, int y)
        {
            var position = new Spot() { X = x , Y= y};
            var ship = new Ship { Position = position   };
            PlayerShips.Add(ship);
        }

        public void Attack(int x, int y , GameBoard enemyBoard) 
        {
            Spot spt = enemyBoard.Board[x, y];
            if (spt.HasShip)
            {

            }
        }


    }
}
