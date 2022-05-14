using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Problem10
    {
        /*
         The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
         Find the sum of all the primes below two million.
        */

        //TODO: It takes around 120 second and this is too long for me!
        public static void Solution()
        {
            var primeNumbers = new List<long>();
            var maxPrimeNumber = 2000000;

            for (int i = 1; i < maxPrimeNumber; i++)
            {
                var divided = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (divided > 2)
                        break;


                    if (i % j == 0)
                        if (j != 1 && j != i)
                            break;
                        else
                            divided++;
                }


                if (divided == 2)
                    primeNumbers.Add(i);


                divided = 0;
            }


            Console.WriteLine(primeNumbers.Sum().ToString("##,###"));
        }
    }
}
