using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperFish
{
    class Board
    {
        public Pieces WhitePieces { get; private set;  }
        public Pieces BlackPieces { get; private set; }
        public int[,] BoardState { get; private set; }
        public Board()
        {
            WhitePieces = new Pieces(true);
            BlackPieces = new Pieces(false);
            BoardState = new int[7, 7];
        }
    }
}
