using System;

namespace KasperFish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Init: Thread ID: {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
            var game = new Board();
            for (var index0 = 0; index0 < game.BoardState.GetLength(0); index0++)
            for (var index1 = 0; index1 < game.BoardState.GetLength(1); index1++)
            {
                if (index1 % 8 == 0) Console.WriteLine();
                var t = game.BoardState[index0, index1];
                Console.Write($"{t} ");
            }
        }
    }
}
