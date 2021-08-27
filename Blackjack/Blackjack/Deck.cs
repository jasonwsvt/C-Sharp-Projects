using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Deck
    {
        public Deck(int shuffle=0)
        {
            Cards = new List<Card>();

            foreach (int face in Enum.GetValues(typeof(Face)))
            {
                foreach (int suit in Enum.GetValues(typeof(Suit)))
                {
                    Card card = new Card
                    {
                        Face = (Face)face,
                        Suit = (Suit)suit
                    };
                    Cards.Add(card);
                }
            }

            if (shuffle > 0) { Shuffle(shuffle); }
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
