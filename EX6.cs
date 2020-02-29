using System;

namespace C_ {

    public static class EX6 {

        // Expected return value = 25164150 if n = 100
        public static int Run(int n) {
            
            //This was simple and I do not know if number theory solves this in a different way. 

            int num1 = 0, num2 = 0;

            for(int i = 1; i <= n; i++) {
                num1 += (int)Math.Pow(i, 2);
                num2 += i;
            }
            
            return ((int)Math.Pow(num2, 2)) - num1;
        }
    }
}