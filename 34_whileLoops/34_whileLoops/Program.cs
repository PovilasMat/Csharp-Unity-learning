namespace _34_whileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt for and get health
            Console.WriteLine("Enter your health: ");
            int health = int.Parse(Console.ReadLine());

            // input validation
            while (health < 0 || health > 100)
            {
                Console.WriteLine();
                Console.WriteLine("Health must be between 0 and 100. Please try again: ");
                health = int.Parse(Console.ReadLine());
            }
            // print health
            Console.WriteLine();
            Console.WriteLine("Your health is " + health);

        }
    }
}
