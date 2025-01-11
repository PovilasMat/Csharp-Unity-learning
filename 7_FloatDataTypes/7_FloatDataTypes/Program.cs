namespace _7_FloatDataTypes
{
    internal class Program
    {
        /// <summary>
        /// Demonstrates floating point data types
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int score = 1360;
            int totalSecondsPlayed = 100000;

            // calculate and print points per second
            float pointsPerSecond = (float)score / totalSecondsPlayed;
            Console.WriteLine("Points per second: " + pointsPerSecond);
        }
    }
}
