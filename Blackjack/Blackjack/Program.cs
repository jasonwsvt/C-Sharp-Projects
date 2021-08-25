using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = Shuffle(new Deck());

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> tempList = new List<Card>();
            Random random = new Random();

            while(deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                tempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = tempList;
            return deck;
        } 
    }
}
