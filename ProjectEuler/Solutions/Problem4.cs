using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Problem4
    {
        /*
         A palindromic number reads the same both ways. 
         The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
         Find the largest palindrome made from the product of two 3-digit numbers.
        */

        public static void Solution()
        {
            var resultsOfMultiple = new List<int>();

            for (int firstNumber = 100; firstNumber < 1000; firstNumber++)
            {
                for (int secondNumber = 100; secondNumber < 1000; secondNumber++)
                {
                    resultsOfMultiple.Add(firstNumber * secondNumber);
                }
            }



            var palindromes = new List<int>();
            foreach (var result in resultsOfMultiple)
            {
                var stringOfResult = result.ToString();
                var arrayOfResult = stringOfResult.ToCharArray();

                Array.Reverse(arrayOfResult);

                var reversStringOfResult = "";
                foreach (var r in arrayOfResult)
                {
                    reversStringOfResult += r;
                }

                if(stringOfResult == reversStringOfResult)
                    palindromes.Add(result);
            }


            Console.WriteLine(palindromes.Max());
        }
    }
}
