using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Problem3
    {
        /*
         The prime factors of 13195 are 5, 7, 13 and 29.
         What is the largest prime factor of the number 600851475143 ?
        */

        public static void Solution()
        {
            const long number = 600851475143;
            var factorsOfNumber = new List<long>();
            var primeFactors = new List<long>();


            for (long i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    factorsOfNumber.Add(i);
            }
            

            var factorsNumber = 0;
            foreach (var factor in factorsOfNumber)
            {
                for (long i = 1; i <= factor; i++)
                {
                    if(factorsNumber > 2)
                        break;


                    if (factor % i == 0)
                        factorsNumber++;
                }


                if (factorsNumber == 2)
                    primeFactors.Add(factor);


                factorsNumber = 0;
            }


            Console.WriteLine(primeFactors.Max());

        }
    }
}
