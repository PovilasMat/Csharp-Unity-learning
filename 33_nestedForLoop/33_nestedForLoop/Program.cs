using System.Data;

namespace _33_nestedForLoop
{
    internal class Program
    {
        /// <summary>
        /// Nested For Loops lecture code
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table");
            // print table header
            Console.Write("     ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0, 5}", i);
            }
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0, 5}", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0, 5}", i * j);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Rectangular sterisk table");
            Console.WriteLine("Write number of rows in the table: ");
            if (int.TryParse(Console.ReadLine(), out int rowsAsterisks))
            {
                Console.WriteLine("Write number of columns in the table: ");
                if (int.TryParse(Console.ReadLine(), out int columnsAsterisks))
                {
                    for (int i = 0; i < rowsAsterisks; i++)
                    {
                        for (int j = 0; j < columnsAsterisks; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("Growing asterisk table");
            Console.WriteLine("Write upper limit of asterisks: ");
            if (int.TryParse(Console.ReadLine(), out int limitAsterisk))
            {
                for (int i = 0; i < limitAsterisk; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
