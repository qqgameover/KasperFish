using System;

namespace KasperFish
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Board();
            Console.WriteLine(game.WhitePieces.PieceCount[0, 1]);
        }
    }
}
