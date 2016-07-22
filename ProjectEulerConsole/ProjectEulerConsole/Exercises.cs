using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerConsole
{
    class Exercises
    {

        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        /// The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public static double ExerciseOne(int maxNum)
        {
            List<double> numberList = new List<double>();
            for (int i = 0; i < maxNum; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    numberList.Add(i);
                }

            }
            double result = numberList.Sum();
            return result;
        }
    }
}
