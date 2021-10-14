using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperFish
{
    class Ai
    {
        public Piece[,] BoardState { get; private set; }
        public Ai(Piece[,] boardState)
        {
            BoardState = boardState;
        }
    }
}
