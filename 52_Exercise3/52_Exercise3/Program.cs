namespace _52_Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test an apple
            Apple apple = new Apple(0.5F, true);
            Console.WriteLine("Apple amount left: " + apple.AmountLeft);
            Console.WriteLine("Apple is organic: " + apple.Organic);

            Console.WriteLine();
            Apple apple1 = new Apple(true);
            Console.WriteLine("Apple amount left: " + apple1.AmountLeft);
            Console.WriteLine("Apple is organic: " + apple1.Organic);

            Console.WriteLine();
            Console.WriteLine("Taking a bite of the apple");
            apple1.TakeBite(0.2F);
            Console.WriteLine("Apple amount left: " + apple1.AmountLeft);
            Console.WriteLine("Apple is organic: " + apple1.Organic);

            Random random = new Random();
            while (apple1.AmountLeft > 0.0F)
            {
                Console.WriteLine("Taking a bite of the apple");
                if (apple1.AmountLeft < 0.05F)
                {
                    apple1.TakeBite(apple1.AmountLeft);
                }
                else
                {
                    apple1.TakeBite((float)random.NextDouble() * apple1.AmountLeft);
                }
                Console.WriteLine("Apple amount left: " + apple1.AmountLeft);
            }
        }
    }
}
