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
                    Console.Write("enter number lof natural numbers to go through: ");
                    int maxNum;
                    if (int.TryParse(Console.ReadLine(), out maxNum))
                    {
                        double result = Exercises.ExerciseOne(maxNum);
                        Console.WriteLine("sum of multiples of 3's & 5's = " + result);
                    }
                    break;
            }
        }
    }
}
