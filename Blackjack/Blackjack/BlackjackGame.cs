using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class BlackjackGame : Game
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Blackjack players:");
            base.ListPlayers();
        }
    }
}
