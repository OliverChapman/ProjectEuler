using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool anotherTest = false;
            do
            {
                TestSelector();
                Console.Write("would you like to run another test? (y): ");
                if (Console.ReadLine() == "y")
                {
                    anotherTest = true;
                    Console.WriteLine();
                }
            }
            while (anotherTest);
        }
        static void TestSelector()
        {
            Console.Write("Select test number: ");
            string responseString = Console.ReadLine().Trim();
            int responseInt;
            if (!int.TryParse(responseString, out responseInt))
            {
                return;
            }
            else { Tests(responseInt); }
        }
        static void Tests(int response)
        {
            switch (response)
            {
                case 1:
                    Console.Write("enter number of natural numbers to go through: ");
                    int maxNum;
                    if (int.TryParse(Console.ReadLine(), out maxNum))
                    {
                        double result = Exercises.ExerciseOne(maxNum);
                        Console.WriteLine("sum of multiples of 3's & 5's = " + result);
                    }
                    break;
                case 2:
                    Console.Write("enter highest fibonacci number: ");
                    if(int.TryParse(Console.ReadLine(), out maxNum))
                    {
                        double result = Exercises.ExerciseTwo(maxNum);
                        Console.WriteLine("sum of even fibonacci numbers = " + result);
                    }
                    break;
                case 3:
                    Console.Write("enter number to find largest prime factor of: ");
                    if(int.TryParse(Console.ReadLine(), out maxNum))
                    {
                        double result = Exercises.ExerciseThree(maxNum);
                        Console.WriteLine("largest prime factor of " + maxNum + " = " + result);
                    }
                    break;
            }
        }
    }
}
