using System;
using System.Linq;

namespace C_ {

    public static class EX4 {

        public static int Run(int n) {

            //Palindrome is 9009
            //My idea is to take the number into an array and divide the length of the array by 2
            //Match the first index of the array with the first and the last value and if a match is found
            //then increase one index and decrease the other and keep matching until n where n is the 
            //count of the elements in the array divided by 2.
            //My way of converting a number into an array might be slow but the logic works. 

            int largestPalindromeNumber = 0;

            while (n > 1) {

                int[] array = n.ToString().Select(x => Convert.ToInt32(x.ToString())).ToArray();
                if (IsPalindrome(array, 0, array.Count() - 1)) {
                    largestPalindromeNumber = n;
                    break;
                }
                n -= 1;
            }

            return largestPalindromeNumber;
        }

        private static bool IsPalindrome(int[] array, int i, int j) {
            int limit = array.Count() / 2;
            
            while (limit > 0) {
                if(array[i] != array[j]) {
                    return false;
                } else {
                    i++;
                    j--;
                    if (limit == 1) {
                        return true;
                    }
                }
                limit--;
            }

            return false;
        }
    }
}