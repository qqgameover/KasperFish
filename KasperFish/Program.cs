using System;

namespace KasperFish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Init: Thread ID: {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
            var game = new Board();
            var ai = new Ai(game.BoardState);
            Console.WriteLine("Welcome to a janky chess game. You move the pieces by first writing the starting pos, then writing the desired position. Example: a.2 c.1");
            game.DrawBoard();
            while (true)
            {
                var command = Console.ReadLine();
                game.HandleCommand(command);
                Console.Clear();
                game.DrawBoard();
            }
        }
    }
}
