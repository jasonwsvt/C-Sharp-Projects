using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Card
    {
        public Card()
        {

        }
        public Card(string suit, string face)
        {
            Suit = suit;
            Face = face;

        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
