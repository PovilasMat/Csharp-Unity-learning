namespace _32_forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt for and get number of squares to print
            Console.Write("Enter number of squares to print (1-10): ");
            int n = int.Parse(Console.ReadLine());

            // print squares 1 to n
            for (int i=1; i <= n; i++)
            {
                Console.WriteLine(i * i);
            }

            // prompt for maximum number of even numbers to print
            Console.Write("Enter maximum number of even numbers to print: ");
            int m = int.Parse(Console.ReadLine());

            // print even numbers 0 to m
            for (int i = 0; i < m; i++)
            {
                if (i % 2 == 0 && i != 0)
                {
                    Console.WriteLine(i);
                }
            }

            // prompt for number of asterisks to print
            Console.Write("Enter number of asterisks to print: ");
            int p = int.Parse(Console.ReadLine());

            // print p asterisks
            for (int i = 0; i < p; i++)
            {
                Console.Write("*");
            }
        }
    }
}
