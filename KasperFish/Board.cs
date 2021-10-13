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
            for (var i = 0; i < 8; i++)
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
            if (!IsCommandValid(command))
            {
                Console.WriteLine("Nei");
                return;
            }
            var splitCommand = command.Split(" ");
            var startingPos = splitCommand[0].Split(".");
            var newPos = splitCommand[1].Split(".");
            var startingNum = GetPosNum(startingPos[0]);
            var newPosNum = GetPosNum(newPos[0]);
            MovePiece(startingNum, Convert.ToInt32(startingPos[1]), newPosNum, Convert.ToInt32(newPos[1]));
        }

        private void MovePiece(int startingNum, int startingPo, int newPosNum, int newPo)
        {
            BoardState[newPosNum, newPo - 1] = BoardState[startingNum, startingPo - 1];
            BoardState[startingNum, startingPo - 1] = Piece.None;
        }

        private int GetPosNum(string num)
        {
            var upperCased = num.ToUpper();
            return upperCased switch
            {
                "A" => 0,
                "B" => 1,
                "C" => 2,
                "D" => 3,
                "E" => 4,
                "F" => 5,
                "G" => 6,
                "H" => 7,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private static bool IsCommandValid(string command)
        {
            var splitCommand = command.Split(" ");
            return splitCommand[0].Length == 3 && splitCommand[1].Length == 3;
        }
    }
}
