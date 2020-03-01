using System;

namespace C_ {

    public static class EX8 {

        public static long Run() {

            //A bit of a struggle to find the right for loop. 
            
            //You substring 13 digits starting from 0 and calculate the greatest product by
            //converting it into an array. You add 1 to the for loop comparision because 
            //at index 987 when you substring 13 dights you have gotten the last substring. 
            //The product of the numbers is stored in a variable and constantly checked and you
            //always keep track of the largest product and replace only when you have found the 
            //largest number, which is what Math.Max will do. 
            
            const string NUMBER = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            const int adjacent = 13;
            long result = 0;

            for(int i = 0; i + adjacent <= NUMBER.Length; i++) {
                string str = NUMBER.Substring(i, adjacent);
                char[] data = str.ToCharArray();
                long adjacentProduct = 1;
                for(int j = 0; j < adjacent; j++) {
                    adjacentProduct *= int.Parse(data[j].ToString());
                }
                result = Math.Max(adjacentProduct, result);
            }

            return result;
        }
    }
}