using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoTwentyOne
{
    class CardDeck
    {
        private static Random randomize = new Random();
        private const int numOfCards = 52;      // Total number of cards in a deck
        private Card[] deck = new Card[numOfCards];
        private int cardVal;
        private int currentCard;

        public CardDeck()
        {
            string[] faces = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = { "Diamonds", "Hearts", "Spades", "Clubs" };

            // populating deck with Card objects 
            for (var count = 0; count < deck.Length; ++count)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }

        public void Shuffle()
        {
            currentCard = 0;

            for (var first = 0; first < deck.Length; ++first)
            {
                var second = randomize.Next(numOfCards);

                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
