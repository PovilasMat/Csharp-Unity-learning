namespace _22_Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
            int choice = GetUserChoice();
            ExecuteChoice(choice);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("**************");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
        }

        static int GetUserChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice, please enter a number between 1 and 4.");
            }
            return choice;
        }

        static void ExecuteChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Starting a new game...");
                    break;
                case 2:
                    Console.WriteLine("Loading game...");
                    break;
                case 3:
                    Console.WriteLine("Options menu...");
                    break;
                case 4:
                    Console.WriteLine("Quitting game...");
                    break;
            }
        }
    }
}
