using System;

namespace TicTacToe
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the TicTacToe game \n");
            Console.Write("Player 1 name: ");
            string player1Name = Console.ReadLine();
            while (player1Name.Equals(""))
            {
                Console.Write("Player 1 name: ");
                player1Name = Console.ReadLine();

            }

            Console.Write("Player 2 name: ");
            string player2Name = Console.ReadLine();
            while (player2Name.Equals(""))
            {
                Console.Write("Player 2 name: ");
                player2Name = Console.ReadLine();

            }


            Player player1 = new Player(player1Name, 'X', false);
            Player player2 = new Player(player2Name, 'O', false);

            Console.Clear();
            Game game = new();
            game.DisplayTable();
            Console.WriteLine("\n");

            game.PlayGame(player1, player2);

            Console.ReadLine();
        }
    }
}
