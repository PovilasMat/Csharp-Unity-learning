namespace _35_Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a menu for a game. The menu should have the following options:
            // 1 - New Game
            // 2 - Load Game
            // 3 - Options
            // 4 - Quit
            
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");

            Console.Write("Enter your choice: ");
            int choice; 
            int.TryParse(Console.ReadLine(), out choice);
            while (choice != 4)
            {
                // Handle the choice
                Console.Write("Haha, this does nothing, try something else! ");
                int.TryParse(Console.ReadLine(), out choice);
            }
            Console.WriteLine("Thanks for playing, exiting game!");
        }
    }
}
