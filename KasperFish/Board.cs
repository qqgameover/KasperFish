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
                for (var index0W = 0; index0W < WhitePieces.PieceCount.GetLength(0); index0W++)
                for (var index1W = 0; index1W < WhitePieces.PieceCount.GetLength(1); index1W++)
                {
                    var piece = WhitePieces.PieceCount[index0W, index1W];
                    BoardState[index0W, index1W] = piece;

                }

                for (var i = 0; i < BlackPieces.PieceCount.GetLength(0); i++)
                for (var j = 0; j < BlackPieces.PieceCount.GetLength(1); j++)
                {
                    var piece = BlackPieces.PieceCount[i, j];
                    BoardState[i + 6, j] = piece;
                }
            }
        }

        public void DrawBoard()
        {
            string currentBoard = "";
            var lettering = "";
            var numbering = "";
            for (var index0 = 0; index0 < BoardState.GetLength(0); index0++)
            {
                lettering = index0 switch
                {
                    0 => Lettering.A.ToString(),
                    1 => Lettering.B.ToString(),
                    2 => Lettering.C.ToString(),
                    3 => Lettering.D.ToString(),
                    4 => Lettering.E.ToString(),
                    5 => Lettering.F.ToString(),
                    6 => Lettering.G.ToString(),
                    7 => Lettering.H.ToString(),
                    _ => lettering
                };
                for (var index1 = 0; index1 < BoardState.GetLength(1); index1++)
                {
                    if (index1 % 8 == 0)
                    {
                        currentBoard += "\n";
                        currentBoard += lettering;
                    }
                    var t = BoardState[index0, index1];
                    currentBoard += ($"{t}").PadLeft(9);
                }
            }

            Console.WriteLine($"{currentBoard}");
            for (int i = 0; i < 8; i++)
            {
                numbering += (i + 1).ToString().PadLeft(9);
            }
            Console.WriteLine(numbering);
        }

        public bool IsMoveLegal(Piece pieceMoved)
        {
            return true;
        }

        public void HandleCommand(string command)
        {
            
        }
    }
}
