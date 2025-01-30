using System;
using ConsoleCards;
using System.Collections.Generic;

namespace ForLoops
{
    /// <summary>
    /// For Loops lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// For Loops lecture code
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // create a new deck and hand
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();

            // add cards to hand
            hand.Add(deck.TakeTopCard());
            hand.Add(deck.TakeTopCard());
            hand.Add(deck.TakeTopCard());

            // print out the cards in the hand
            foreach (Card card in hand)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }

            // add five more cards to hand
            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            // print out the cards in the hand
            Console.WriteLine();
            for (int i = 0; i < hand.Count; i++)
            {
                Console.WriteLine(hand[i].Rank + " of " + hand[i].Suit);
            }
        }
    }
}
