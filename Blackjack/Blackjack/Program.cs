using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino.  Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, {0}.  Would you like to join a game of Blackjack right now", playerName);
            string answer = Console.ReadLine().ToLower();
            if (new string[] { "yeah", "yes", "y", "ya" }.Any(x => x == answer)) {
                Player player = new(playerName, bank);
                Game game = new BlackjackGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now.");
            Console.Read();
        }
    }
}