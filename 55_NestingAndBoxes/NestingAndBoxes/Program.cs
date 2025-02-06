using System;

namespace NestingAndBoxes
{
    /// <summary>
    /// Nesting and Boxes lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Nesting and Boxes lecture code
        /// 
        /// The idea for this problem comes from Beginning C by Ivor Horton
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // get valid width
            int width = GetValidInput("Enter box width (3-20): ",
                "Width must be between 3 and 20", 3, 20);
            Console.WriteLine();

            // get valid height
            int height = GetValidInput("Enter box height (3-20): ",
                "Height must be between 3 and 20", 3, 20);
            Console.WriteLine();

            // print top row
            PrintCharacter('*', width);
            Console.WriteLine();

            PrintBoxInterior(width, height);

            // print bottom row
            PrintCharacter('*', width);
        }

        /// <summary>
        /// Gets a valid input from the user
        /// </summary>
        /// <param name="promptString">prompt string</param>
        /// <param name="errorString">error string</param>
        /// <param name="lowerBound">lower bound</param>
        /// <param name="upperBound">upper bound</param>
        /// <returns>valid input</returns>
        static int GetValidInput(string promptString,
            string errorString, int lowerBound,
            int upperBound)
        {
            int value;
            Console.Write(promptString);
            value = int.Parse(Console.ReadLine());
            while (value < lowerBound ||
                value > upperBound)
            {
                Console.WriteLine(errorString);
                Console.Write(promptString);
                value = int.Parse(Console.ReadLine());
            }
            return value;
        }

        static void PrintCharacter(char character, int numTimes)
        {
            for (int i = 0; i < numTimes; i++)
            {
                Console.Write(character);
            }
        }

        /// <summary>
        /// Prints the interior of the boxes with the given width and height
        /// </summary>
        /// <param name="width"></param>
        /// <param name=""></param>
        static void PrintBoxInterior(int width, int height)
        {
            // print middle of box
            for (int row = 2; row <= height - 1; row++)
            {
                Console.Write('*');
                PrintCharacter(' ', width - 2);
                Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}
