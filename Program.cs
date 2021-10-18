using System;

namespace CasinoTwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomize = new Random();

            var aDeck = new CardDeck();
            aDeck.Shuffle();
            int playerCardTotal = 0, dealerCardTotal = 0;
            string[] dealer = { "D", "S" };

            Console.WriteLine("Player: [D]eal or [S]top?");
            string userInput = Console.ReadLine();

            while (userInput.ToUpper() != "S")
            {
                string newDeck = Convert.ToString(aDeck.DealCard());
                Console.WriteLine(newDeck);
                playerCardTotal += countingCards(newDeck);

                Console.WriteLine("Player: [D]eal or [S]top?");
                userInput = Console.ReadLine();
            }
            Console.WriteLine(playerCardTotal);

            if (playerCardTotal <= 21)
            {
                Console.WriteLine("You Win!");

                Console.Write("Dealer: [D]eal or [S]top? ");
                //int dealerInput = randomize.Next(dealer.Length);
                string dealerInput = "D";
                //Console.WriteLine(dealer[dealerInput]);
                Console.WriteLine(dealerInput);

                //while (dealer[dealerInput].ToUpper() != "S")
                while (dealerInput.ToString() != "S")
                {
                    string dealerDeck = Convert.ToString(aDeck.DealCard());
                    Console.WriteLine(dealerDeck);
                    dealerCardTotal += countingCards(dealerDeck);

                    Console.Write("Dealer: [D]eal or [S]top? ");
                    Console.WriteLine(dealerInput);
                    //dealerInput = randomize.Next(dealer.Length);
                    if (dealerCardTotal >= 15)
                    {
                        dealerInput = "S";
                    }
                    else
                    {
                        dealerInput = "D";
                    }
                }
                Console.WriteLine(dealerCardTotal);

                if (dealerCardTotal <= 21)
                {
                    Console.WriteLine("Dealer Win!");
                }
                else
                {
                    Console.WriteLine("Dealer Lose!");
                }

                if (dealerCardTotal > playerCardTotal)
                {
                    Console.WriteLine("DEALER WINS!!!");
                }
                else
                {
                    Console.WriteLine("PLAYER WINS!!!");
                }
            }
            else
            {
                Console.WriteLine("You Lose!");
            }

        }

        public static int countingCards(string newCard)
        {
            int cardCount = 0;
            if (newCard.Contains("Ace"))
                cardCount += 1;
            else if (newCard.Contains("Jack") || newCard.Contains("Queen") || newCard.Contains("King"))
                cardCount += 10;
            else
            {
                int numDeck = Convert.ToInt32(newCard.Substring(0, newCard.IndexOf(' ')));
                cardCount += numDeck;
            }
            return cardCount;
        }
    }
}
