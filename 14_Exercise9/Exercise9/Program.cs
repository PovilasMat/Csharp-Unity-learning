using System;

namespace Exercise9
{
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck deck = new Deck();
            deck.Print();

            // tell the deck to shuffle and print itself
            Console.WriteLine();
            Console.WriteLine("Shuffling the deck...");
            deck.Shuffle();
            deck.Print();

            // take the top card from the deck and print the card rank and suit
            Console.WriteLine();
            Card card1 = deck.TakeTopCard();
            Console.WriteLine(card1.Rank + " of " + card1.Suit);

            // take the top card from the deck and print the card rank and suit
            Console.WriteLine();
            Card card2 = deck.TakeTopCard();
            Console.WriteLine(card2.Rank + " of " + card2.Suit);
        }
    }
}
