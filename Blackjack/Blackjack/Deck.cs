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

        public void Shuffle(int times = 1)
        {
            Random random = new Random();

            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = tempList;
            }
        }
    }
}
