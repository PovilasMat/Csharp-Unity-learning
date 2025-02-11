namespace _64_Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the month of your birth");
            var month = Console.ReadLine();

            Console.WriteLine("Print the day of your birth");
            var day = int.Parse(Console.ReadLine());

            Console.WriteLine("Is " + month + " " + day + "th your birthday? How do I know? Haha!");

            Console.WriteLine("You will receive a special birthday promotion on " + month + " " + (day-1));
        }
    }
}
