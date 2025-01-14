namespace _20_If_Statements
{
    /// <summary>
    /// Demonstrates various forms of if statements.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt for and get user input
            Console.Write("Pick up the shiny thing? (1 for yes, 2 for no): ");
            int answer = int.Parse(Console.ReadLine());

            // print appropriate statement with if statement
            //if ( answer == 1 )
            //{
            //    Console.WriteLine("You have the shiny thing");
            //}
            //else if (answer == 2)
            //{
            //    Console.WriteLine("You do not have the shiny thing");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input, dork!");
            //}

            // print appropriate statement with switch statement
            switch (answer)
            {
                case 1:
                    Console.WriteLine("You have the shiny thing");
                    break;
                case 2:
                    Console.WriteLine("You do not have the shiny thing");
                    break;
                default:
                    Console.WriteLine("Invalid input, dork!");
                    break;
            }
        }
    }
}
