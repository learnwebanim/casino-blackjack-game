using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoTwentyOne
{
    class Card
    {
        private string Face { get; }        // Card's Faces, i.e. Ace, King, Jack, ...
        private string Suit { get; }        // Card's Suit, i.e. Diamonds, Spades, ...

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Face} of {Suit}";
        }
    }
}
