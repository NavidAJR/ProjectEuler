using System;
using System.Collections.Generic;

namespace Solutions
{
    public class Problem7
    {
        /*
         By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
         What is the 10 001st prime number?
        */


        public static void Solution()
        {
            var primeNumbers = new List<long>();
            var maxLength = 10001;

            for (int i = 1; i < int.MaxValue; i++)
            {
                var divided = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(divided > 2)
                        break;


                    if (i % j == 0)
                       if(j != 1 && j != i)
                           break;
                       else
                           divided++;
                }
                

                if(divided == 2)
                    primeNumbers.Add(i);


                if(primeNumbers.Count == maxLength)
                    break;


                divided = 0;
            }


            Console.WriteLine(primeNumbers[10000]);
        }
    }
}