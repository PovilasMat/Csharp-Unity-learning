namespace _6_IntegerDataTypes
{
    /// <summary>
    /// Integer Data Types lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates integer data types
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;

            // calculate minutes and seconds played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;

            // print minutes and seconds played
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);

            int age;
            age = 31;
            Console.WriteLine("Age: " + age);

            Console.WriteLine();
            Console.Write("Enter the first altitude: ");
            int altitude1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second altitude: ");
            int altitude2 = int.Parse(Console.ReadLine());

            int altitudeChange = altitude2 - altitude1;

            Console.WriteLine();
            Console.WriteLine("Altitude change from altitude 1 to altitude 2 is: " + altitudeChange);
        }
    }
}
