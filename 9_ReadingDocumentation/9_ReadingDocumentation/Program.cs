namespace _9_ReadingDocumentation
{
    /// <summary>
    /// Reading Documentation lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates reading documentation
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // calculate and print cosine of 45 degree

            //example of type casting with Math class
            float cosine1 = (float)Math.Cos(45 * Math.PI / 180);
            Console.WriteLine("Cosine of 45 degrees: " + cosine1);

            //example of using MathF class
            float cosine2 = MathF.Cos(45 * MathF.PI / 180);
            Console.WriteLine("Cosine of 45 degrees: " + cosine2);

        }
    }
}
