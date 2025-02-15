﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Problem6
    {
        /*
         The sum of the squares of the first ten natural numbers is,
                   1^2 + 2^2 + ... + 10^2 = 385
           
         The square of the sum of the first ten natural numbers is,
                   (1 + 2 + ... + 10)^2 = 55^2 = 3025 
        
         Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is,
                   3025 - 385 = 2640

         Find the difference between the sum of the squares of the first one hundred natural numbers 
         and the square of the sum.
        */


        public static void Solution()
        {
            double sumOfTheSquares = 0;
            double squareOfTheSum = 0;
            var numbersRange = 100;

            for (int i = 1; i <= numbersRange; i++)
            {
                sumOfTheSquares += Math.Pow(i, 2);
            }


            double sumOfTheNumbersInTheRange = 0;
            for (int i = 1; i <= numbersRange; i++)
            {
                sumOfTheNumbersInTheRange += i;
            }

            squareOfTheSum = Math.Pow(sumOfTheNumbersInTheRange, 2);


            Console.WriteLine((squareOfTheSum - sumOfTheSquares).ToString("##,###"));
        }
    }
}
