using System;

namespace C_
{
    public static class EX1
    {
        // Expected return value = 233168
        public static int Run(int n)
        {
            //To find multiples of 3 and 5 below 1000 we have to know which number below 1000
            // leaves a reminder of 0. So we start from 3 and loop till less than 1000
            int sum = 0;

            for(int i = 3; i < 1000; i++) {
                if(i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }
            }

            return sum;
        }
    }
}