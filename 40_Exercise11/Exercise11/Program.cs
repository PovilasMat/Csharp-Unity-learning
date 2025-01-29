using System;
using ConsoleCards;

namespace Exercise11
{
    /// <summary>
    /// Exercise 11
    /// </summary>
    class Program
    {
        /// <summary>
        /// Exercise 11
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Card[] cards = new Card[5];
            deck.Shuffle();
            Console.WriteLine("Your hand:");
            for (int i = 0; i < 5; i++)
            {
                cards[i] = deck.TakeTopCard();
                cards[i].FlipOver();
                cards[i].Print();
                //Console.WriteLine(cards[i].Rank + " of " + cards[i].Suit);
            }
        }
    }
}
