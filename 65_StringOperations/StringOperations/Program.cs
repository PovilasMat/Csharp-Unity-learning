using System;

namespace StringOperations
{
    /// <summary>
    /// String Operations lecture code
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            // read in csv string
            Console.Write("Enter name and percent (name,percent): ");
            string csvString = Console.ReadLine();

            // find comma location
            int commaLocation = csvString.IndexOf(',');

            // validate input
            if (commaLocation == -1)
            {
                Console.WriteLine("Error: Input does not contain a comma.");
                return;
            }

            // extract name and percent
            string name = csvString.Substring(0, commaLocation);
            string percentString = csvString.Substring(commaLocation + 1);

            if (float.TryParse(percentString, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float percent)) // I need to use InvariantCulture to make sure that the decimal separator is a dot
            {
                // print name and percent
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Percent: " + percent);
            }
            else
            {
                Console.WriteLine("Error: Percent is not in a correct format.");
            }
        }
    }
}
