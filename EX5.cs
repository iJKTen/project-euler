using System;

namespace C_ {

    public static class EX5 {

        public static int Run() {
            
            //So I am sure there is a better way to do this vianumber theory but I don't know that yet. 
            //2520 is divisible by all numbers from 1-10 so the number divisible from 1-20
            //will be greater than 2520 and my idea is to start finding a number divisible from 1-20
            //greater than 2520.

            int smallestNumber = 0, n = 2520;
            bool reminderIsZero = true;

            do {
                for(int i = 2; i <= 20; i++) {
                    reminderIsZero = true;
                    if(n % i != 0) {
                        n++;
                        reminderIsZero = false;
                        break;
                    }
                }

                if(reminderIsZero) {
                    smallestNumber = n;
                }
            } while(reminderIsZero == false);

            return smallestNumber;
        }
    }
}