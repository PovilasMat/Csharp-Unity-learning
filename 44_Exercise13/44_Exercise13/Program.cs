using System.Collections.Generic;

namespace _44_Exercise13
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 1; i < 11; i++)
            {
                list.Add(i);
            }
            Console.WriteLine(list.Count);

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(list.Count);

            // buggy way
            Console.WriteLine();
            List<int> list2 = new List<int>();
            for (int i = 1; i < 6; i++)
            {
                list2.Add(i);
            }
            foreach (int i in list2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i] == 1 | list2[i] == 2 | list2[i] == 3)
                {
                    list2.Remove(i);
                }
            }
            foreach (int i in list2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
