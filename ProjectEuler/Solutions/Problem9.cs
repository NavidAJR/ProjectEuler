using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Problem9
    {
        /*
         A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
                   a2 + b2 = c2
         For example, 32 + 42 = 9 + 16 = 25 = 52.
           
         There exists exactly one Pythagorean triplet for which a + b + c = 1000.
         Find the product abc.
        */


        public static void Solution()
        {
            var isFound = false;
            for (int a = 1; a <= 1000; a++)
            {
                for (int b = 1; b <= 1000; b++)
                {
                    for (int c = 1; c <= 1000; c++)
                    {
                        if (a + b + c == 1000 && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        {
                            isFound = true;
                            Console.WriteLine((a * b * c).ToString("##,###"));
                            break;
                        }
                    }


                    if(isFound)
                        break;
                }


                if (isFound)
                    break;
            }
        }
    }
}
