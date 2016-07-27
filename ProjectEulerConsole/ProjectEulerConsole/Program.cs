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
            bool anotherTest;
            do
            {
                anotherTest = false;
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
                    double maxNumDouble;
                    if(double.TryParse(Console.ReadLine(), out maxNumDouble))
                    {
                        double result = Exercises.ExerciseThree(maxNumDouble);
                        Console.WriteLine("largest prime factor of " + maxNumDouble + " = " + result);
                    }
                    break;
                case 4:
                    Console.Write("enter number of digits to find largest palendrome ie 3 digits: ");
                    if (int.TryParse(Console.ReadLine(), out maxNum))
                    {
                        double result = Exercises.ExerciseFour(maxNum);
                        Console.WriteLine("largest palendrome with  " + maxNum + " digits = " + result);
                    }
                    break;
            }
        }
    }
}
