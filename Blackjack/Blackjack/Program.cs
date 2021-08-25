using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            Deck deck = Shuffle(new Deck(), 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
        }

        public static Deck Shuffle(Deck deck, int times = 1)
        {
            Random random = new Random();

            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    tempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = tempList;
            }
            return deck;
        }
    }
}