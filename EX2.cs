using System;

namespace C_ {

    public static class EX2 {

        // Expected return value = 4613732
        public static int Run(long n) {

            //Fibonacci = you start with 0 and 1 and you add those two numbers to get a thrid number.
            // 0 - grandFather and 1 = father. In the next loop grandFather becomes the father and the result 
            // from the previous operation becomes tha father. Keep track of even numbers.
            int evenValuedSum = 0;
            int grandFather = 0, father = 1, result = 0;

            while (result < 4000000) {
                result = grandFather + father;
                grandFather = father;
                father = result;

                if ( result % 2 == 0) {
                    evenValuedSum += result;
                }
            }

            return evenValuedSum;
        }
    }
}