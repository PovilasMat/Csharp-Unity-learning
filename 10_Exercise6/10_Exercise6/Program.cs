namespace _10_Exercise6
{
    // Calculate and display cosine and sine of the angle prompted by the user
    internal class Program
    {
        static void Main(string[] args)
        {
            float angle;
            System.Console.Write("Enter the angle: ");
            angle = float.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Cosine: " + System.Math.Cos(angle * (float)Math.PI / 180));
            System.Console.WriteLine("Sine: " + System.Math.Sin(angle * (float)Math.PI / 180));
        }
    }
}
