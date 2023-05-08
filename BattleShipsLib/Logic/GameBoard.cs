using BattleShipsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsLib.Logic
{
    public class GameBoard
    {
        public  int Width { get; set; }  
        public int Height { get; set; } 

        public Spot[,] Board { get; set; }

        List<Ship> Ships { get; set; } = new List<Ship>();

        public GameBoard(int x = 5, int y = 5)
        {
            Width = x; Height = y;
             if (x<0  || y < 0)
            {
                throw new ArgumentException("Error: Board Width and Height must be positve values");
            }

            InitBoard();
            
        }


        private void InitBoard()
        {
            Board = new Spot[Width, Height];

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Board[i, j] = new Spot { X = i, Y = j };
                }
            }
        }

        private bool IsInsideBaord(int x, int y)
        {
            var result = true;

            if ( x > Width || y > Height)
            {
                result = false;
            }

            return result;
        }

        private bool IsSpotAllocated(Spot spt)
        {
            var result = false;

            foreach (var ship in Ships)
            {
                if (ship.Position == spt)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }


        public bool PlaceAship(Ship ship , int x , int y)
        {
      

            if (!IsInsideBaord(x, y) || IsSpotAllocated(Board[x, y])) return false;

            Spot spt = Board[x, y];
            ship.Position = spt;
            Ships.Add(ship);

            return true;
        }



        


        
    }
}
