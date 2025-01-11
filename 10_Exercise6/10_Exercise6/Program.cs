namespace _10_Exercise6
{
    // Calculate and display cosine and sine of the angle prompted by the user
    internal class Program
    {
        static void Main(string[] args)
        {
            float angle;
            Console.Write("Enter the angle: ");
            angle = float.Parse(Console.ReadLine());
            Console.WriteLine("Cosine: " + Math.Cos(angle * (float)Math.PI / 180));
            Console.WriteLine("Sine: " + Math.Sin(angle * (float)Math.PI / 180));
        }
    }
}
