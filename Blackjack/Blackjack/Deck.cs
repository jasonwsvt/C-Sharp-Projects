using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            foreach (string suit in new string[] { "Hearts", "Diamonds", "Spades", "Clubs"})
            {
                foreach (string face in new string[] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" })
                {
                    Cards.Add(new Card(suit, face));
                }
            }

        }
        public List<Card> Cards { get; set; }
    }
}
