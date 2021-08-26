using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            BlackjackGame game = new BlackjackGame
            {
                Players = new List<string>() { "One", "Two", "Three" },
                Name = "Blackjack",
                Dealer = "Computer"
            };

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
        }
    }
}