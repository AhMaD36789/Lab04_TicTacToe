using System;
using System.Text.RegularExpressions;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                StartGame();
                Console.WriteLine("\nDo you want to play again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "n")
                    Environment.Exit(0);
            }
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.

            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

            Player p1 = new Player();
            p1.Name = "p1";
            p1.Marker = "X";
            p1.IsTurn = true;
            Player p2 = new Player();
            p2.Name = "p2";
            p2.Marker = "O";
            p2.IsTurn = false;
            Game newGame = new Game(p1, p2);
            newGame.Play();
        }
    }
}
