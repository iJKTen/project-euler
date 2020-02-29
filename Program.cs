using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = EX7.Run(10001);
            Console.WriteLine($"The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is {x}");
        }
    }
}
