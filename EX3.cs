using System;
using System.Linq;
using System.Collections;

namespace C_ {

    public static class EX3 {

        // Expected return value = 6857
        public static int Run(long n) {

            // Draw your factor tree for example
            // if n = 21 then 3 * 7 = 21 where 3 is i and 7 becomes the new n
            // 4 becomes the new i after the first while and 7 > 1 but 4 % 7 != 0 and keep incrementing i
            // The largest prime will be 7

            //To find the largest prime factor of a number divide that number with all the prime numbers
            // track the prime numbers in an array. After you have all your primen numbers the array
            // will contain prime numbers in an ascending order, 
            // so reverse the array and pick the first number.
            // Start with the smallest prime number, 2.

            ArrayList factors = new ArrayList();
            long i = 2;

            while(n > 1) 
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n = n / i;
                }
                i = i + 1;
            }

            return int.Parse(factors.ToArray().Reverse().First().ToString());
        }
    }
}