using System.Security.Cryptography.X509Certificates;

namespace _36_NestingAndBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;

            // get valid width
            Console.Write("Enter box width (3-20): ");
            width = int.Parse(Console.ReadLine());
            while (width < 3 || width > 20)
            {
                Console.Write("Invalid width. Enter box width (3-20): ");
                width = int.Parse(Console.ReadLine());
            }

            // get valid height
            Console.Write("Enter box height (3-20): ");
            height = int.Parse(Console.ReadLine());
            while (height < 3 || height > 20)
            {
                Console.Write("Invalid height. Enter box height (3-20): ");
                height = int.Parse(Console.ReadLine());
            }
            // draw box
            DrawBox(width, height);
        }
        static void DrawBox(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
