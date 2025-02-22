namespace Exceptions
{
    /// <summary>
    /// Exceptions lectures code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates exceptions and exception handling
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            try
            {
                // prompt for and get a short
                Console.Write("Enter a whole number (-32,768 to 32,767): ");
                short input = short.Parse(Console.ReadLine());
            }
            catch (FormatException fe) 
            {
                Console.WriteLine("That's not a whole number!");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("That number is out of range!");
            }
            finally
            {
                Console.WriteLine("All done");
            }
        }
    }
}