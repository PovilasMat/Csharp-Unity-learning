namespace _66_CSVs_for_Me
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a csv string in this format <pyramid slot number>,<block letter>,<whether or not the block should be lit>: ");
            String csvString = Console.ReadLine();
            
            // pyramid slot number
            int commaLocation = csvString.IndexOf(",");
            int pyramidSlotNumber = int.Parse(csvString.Substring(0,commaLocation));

            // char block letter
            csvString = csvString.Substring(commaLocation+1);
            commaLocation = csvString.IndexOf(",");
            char blockLetter = csvString[0];

            // bool block lit
            csvString = csvString.Substring(commaLocation + 1);
            bool blockLit = bool.Parse(csvString);

            Console.WriteLine("Pyramid Slot Number: " + pyramidSlotNumber);
            Console.WriteLine("Block Letter: " + blockLetter);
            Console.WriteLine("Block Lit: " + blockLit);

        }
    }
}
