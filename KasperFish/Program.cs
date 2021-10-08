using System;

namespace KasperFish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Init: Thread ID: {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
            var game = new Board();
            game.DrawBoard();
            while (true)
            {
            }
        }
    }
}
