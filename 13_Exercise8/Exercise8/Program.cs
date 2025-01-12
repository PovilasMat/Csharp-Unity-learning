using System;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice
            Die die1 = new Die();
            Die die2 = new Die();

            // tell the dice to roll themselves
            die1.Roll();
            die2.Roll();
            Console.WriteLine("First dice is {0}, second dice is {1}", die1.TopSide, die2.TopSide);
            Console.WriteLine("The sum of the dice is {0}", die1.TopSide + die2.TopSide);
            // print the top sides and the sum of the dice
        }
    }
}
