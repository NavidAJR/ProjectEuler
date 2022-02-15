using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Problem5
    {
        /*
         2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
         What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        */

        //TODO: It takes around 3 second and this is too long for me!
        public static void Solution()
        {
            var succeed = 0;
            const int divideRange = 20;

            for (long i = 1; i < long.MaxValue; i++)
            {
                for (var j = 1; j <= divideRange; j++)
                {
                    if (i % j == 0)
                        succeed++;
                    else
                        break;
                }


                if (succeed == divideRange)
                {
                    Console.WriteLine(i);
                    break;
                }
                    

                succeed = 0;
            }
        }
    }
}

