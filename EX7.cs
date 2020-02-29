using System;
using System.Collections;
using System.Collections.Generic;

namespace C_ {

    public static class EX7 {

        public static int Run(int n) {

            //Start counting at 2 and make it an infinite loop. Be careful of stackoverflow for large numbers
            //Check if a number is prime and if it is keep track of the position and increment that position
            //if position == n then you have a prime number at that position and return that number.

            int primeAtPositionN = 0;
            int totalPrimeNumbers = 0;

            for (int i = 2; true; i++) {
                if (isPrime(i)) {
                    totalPrimeNumbers++;
                }

                if(totalPrimeNumbers == n) {
                    primeAtPositionN = i;
                    break;
                }
            }

            return primeAtPositionN;
        }

        private static bool isPrime(int n) {

            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int boundary = (int)(Math.Floor(Math.Sqrt(n)));

            for(int i = 3; i <= boundary; i++) {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}