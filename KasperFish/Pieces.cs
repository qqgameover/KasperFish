using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperFish
{
    class Pieces
    {
        public bool IsWhite { get; private set; }
        public Piece[,] PieceCount { get; private set; }
        public Pieces(bool white)
        {
            switch (white)
            {
                case true:
                {
                    IsWhite = true;
                    PieceCount = new Piece[2, 8];
                    for (var index0 = 0; index0 < PieceCount.GetLength(0); index0++)
                    for (var index1 = 0; index1 < PieceCount.GetLength(1); index1++)
                    {
                        PieceCount[index0, index1] = index0 switch
                        {
                            0 => index1 switch
                            {
                                0 or 7 => Piece.Rook,
                                1 or 6 => Piece.Knight,
                                2 or 5 => Piece.Bishop,
                                3 => Piece.Queen,
                                4 => Piece.King,
                                _ => PieceCount[index0, index1]
                            },
                            1 => Piece.Pawn,
                            _ => PieceCount[index0, index1]
                        };
                    }
                    break;
                }
                case false:
                {
                    IsWhite = false;
                    PieceCount = new Piece[2, 8];
                    for (var index0 = 0; index0 < PieceCount.GetLength(0); index0++)
                    for (var index1 = 0; index1 < PieceCount.GetLength(1); index1++)
                    {
                        PieceCount[index0, index1] = index0 switch
                        {
                            1 => index1 switch
                            {
                                0 or 7 => Piece.BRook,
                                1 or 6 => Piece.BKnight,
                                2 or 5 => Piece.BBishop,
                                3 => Piece.BQueen,
                                4 => Piece.BKing,
                                _ => PieceCount[index0, index1]
                            },
                            0 => Piece.BPawn,
                            _ => PieceCount[index0, index1]
                        };
                    }
                    break;
                }
            }
        }

        public bool PawnLegalMove(Piece movedPawn, int startingPosNum, int startingPos, int newPosNum, int newPos)
        {
            var firstMove = movedPawn == Piece.Pawn ? 1 : 5;
            var startL = movedPawn == Piece.Pawn ? 2 : -2; 
            if (startingPosNum + startL < newPosNum) return false;
            return true;
        }
        public bool RookLegalMove(Piece movedPawn, int startingPosNum, int startingPos, int newPosNum, int newPos)
        {
            return true;
        }
        public bool KnightLegalMove(Piece movedPawn, int startingPosNum, int startingPos, int newPosNum, int newPos)
        {
            return true;
        }
        public bool BishopLegalMove(Piece movedPawn, int startingPosNum, int startingPos, int newPosNum, int newPos)
        {
            return true;
        }
        public bool QueenLegalMove(Piece movedPawn, int startingPosNum, int startingPos, int newPosNum, int newPos)
        {
            return true;
        }
        public bool KingLegalMove(Piece movedPawn, int startingPosNum, int startingPos, int newPosNum, int newPos)
        {
            return true;
        }
    }
}
