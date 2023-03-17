using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number of horizontal lines for the array: "); 
            int x = Console.Read();

            Console.WriteLine("Write the number of vertical lines for the array: ");
            int y = Console.Read();

            float[,] matrix = new float[x, y];
        }
    }
}
