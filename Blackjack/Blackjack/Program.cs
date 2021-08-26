using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            //            BlackjackGame game = new BlackjackGame
            //            {
            //                Players = new List<Player>() { "One", "Two", "Three" },
            //                Name = "Blackjack",
            //                Dealer = "Computer"
            //            };
            //           game.ListPlayers();

            Game game = new BlackjackGame
            {
                Players = new List<Player>()
            };
            Player player = new Player
            {
                Name = "Computer 1"
            };
            game += player;
            game -= player;

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
        }
    }
}