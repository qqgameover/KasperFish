using System;

namespace KasperFish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Init: Thread ID: {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
            var game = new Board();
            DrawBoard(game);
            while (true)
            {
            }
        }

        private static void DrawBoard(Board game)
        {
            string currentBoard = "";
            var lettering = "";
            for (var index0 = 0; index0 < game.BoardState.GetLength(0); index0++)
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
                for (var index1 = 0; index1 < game.BoardState.GetLength(1); index1++)
                {
                    if (index1 % 8 == 0)
                    {
                        currentBoard += "\n";
                        currentBoard += lettering;
                    }
                    var t = game.BoardState[index0, index1];
                    currentBoard += ($"{t}").PadLeft(9);
                }
            }

            Console.WriteLine($"{currentBoard}");
        }
    }
}
