using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Write a string: ");
            string words = Console.ReadLine();

            Console.WriteLine("Write a character: ");
            string character = Console.ReadLine();

            string newstring = "";

            foreach (char w in words)
            {
                if (w.ToString() != character)
                {
                    newstring += w;
                }   
            }
            Console.WriteLine(newstring);
            
                
        }
    }
}
