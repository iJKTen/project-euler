using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = EX4.Run(999 * 999);
            Console.WriteLine($"Largest palindrome made from the product of 3-digit numnbers is {x}");
        }
    }
}
