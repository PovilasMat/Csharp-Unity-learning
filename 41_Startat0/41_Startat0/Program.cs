namespace _41_Startat0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short[] scores = { 100, 95, 90, 85, 80 };

            // output array information
            // ugly unsafe access to address of array element
            // note use of unsafe block and compiled with unsafe code
            unsafe
            {
                fixed (short* elementAddress = &scores[0])
                {
                    System.Console.WriteLine("First element at address: {0}", (short)elementAddress);
                }
                fixed (short* elementAddress = &scores[1])
                {
                    System.Console.WriteLine("Second element at address: {0}", (short)elementAddress);
                }
                fixed (short* elementAddress = &scores[2])
                {
                    System.Console.WriteLine("Third element at address: {0}", (short)elementAddress);
                }
                fixed (short* elementAddress = &scores[3])
                {
                    System.Console.WriteLine("Fourth element at address: {0}", (short)elementAddress);
                }
                fixed (short* elementAddress = &scores[4])
                {
                    System.Console.WriteLine("Fifth element at address: {0}", (short)elementAddress);
                }
            }
        }
    }
}