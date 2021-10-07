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
        public Piece[,] BoardState { get; private set; }
        public Board()
        {
            WhitePieces = new Pieces(true);
            BlackPieces = new Pieces(false);
            BoardState = new Piece[8, 8];

            for (var index0 = 0; index0 < BoardState.GetLength(0); index0++)
            for (var index1 = 0; index1 < BoardState.GetLength(1); index1++)
            {
                BoardState[index0, index1] = Piece.None;
                for (var index0w = 0; index0w < WhitePieces.PieceCount.GetLength(0); index0w++)
                for (var index1w = 0; index1w < WhitePieces.PieceCount.GetLength(1); index1w++)
                {
                    var piece = WhitePieces.PieceCount[index0w, index1w];
                    BoardState[index0w, index1w] = piece;

                }

                for (int i = 0; i < BlackPieces.PieceCount.GetLength(0); i++)
                for (int j = 0; j < BlackPieces.PieceCount.GetLength(1); j++)
                {
                    var piece = BlackPieces.PieceCount[i, j];
                    BoardState[i + 6, j] = piece;
                }
            }
        }
    }
}
