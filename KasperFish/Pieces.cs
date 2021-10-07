using System;
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
                    PieceCount = new Piece[1, 7];
                    for (var index0 = 0; index0 < PieceCount.GetLength(0); index0++)
                    for (var index1 = 0; index1 < PieceCount.GetLength(1); index1++)
                    {
                        PieceCount[index0, index1] = index0 switch
                        {
                            1 => Piece.Pawn,
                            0 => index1 switch
                            {
                                0 or 7 => Piece.Rook,
                                1 or 6 => Piece.Knight,
                                2 or 5 => Piece.Bishop,
                                3 => Piece.Queen,
                                4 => Piece.King,
                                _ => PieceCount[index0, index1]
                            },
                            _ => PieceCount[index0, index1]
                        };
                    }
                    break;
                }
                case false:
                {
                    PieceCount = new Piece[1, 7];
                    for (var index0 = 0; index0 < PieceCount.GetLength(0); index0++)
                    for (var index1 = 0; index1 < PieceCount.GetLength(1); index1++)
                    {
                        PieceCount[index0, index1] = index0 switch
                        {
                            0 => Piece.Pawn,
                            1 => index1 switch
                            {
                                0 or 7 => Piece.Rook,
                                1 or 6 => Piece.Knight,
                                2 or 5 => Piece.Bishop,
                                4 => Piece.Queen,
                                3 => Piece.King,
                                _ => PieceCount[index0, index1]
                            },
                            _ => PieceCount[index0, index1]
                        };
                    }
                    break;
                    }
            }
        }
    }
}
