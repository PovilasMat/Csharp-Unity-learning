using System;
using System.IO;

namespace _74_Exercise2_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = null;
            List<string> lines = new List<string>();
            try
            {
                input = File.OpenText("text.txt");
                string line = input.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    lines.Add(line);
                    line = input.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (input != null)
                {
                    input.Close();
                }

                StreamWriter output = null;
                try
                {
                    output = File.CreateText("text2.txt");
                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (i % 2 == 1) // Only write lines with odd indices (even-numbered lines)
                        {
                            output.WriteLine(lines[i]);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (output != null)
                    {
                        output.Close();
                    }
                }
            }
        }
    }
}
