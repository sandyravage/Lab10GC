using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10GC
{
    class Program
    {
        public static int counter = 0;
        public static Validator valid = new Validator();
        static void Main()
        {
            Console.WriteLine("Welcome to the Circle Tester.");
            while (true)
            {
                counter++;
                Console.Write("Enter radius: ");
                Circle circle = new Circle(valid.NumberValidator(Console.ReadLine()));
                Console.Write($"Circumference: {circle.CalculateFormattedCircumference(circle.CalculateCircumference())}" +
                    $"\nArea: {circle.CalculateFormattedArea(circle.CalculateArea())}" +
                    $"\nContinue? (y/n): ");
                if(valid.YesNoChecker(Console.ReadLine()) == "y")
                {
                    continue;
                }
                break;
            }
            Console.WriteLine($"Goodbye. You created {counter} circle object(s). Press any key to exit.");
            Console.ReadKey();
        }
    }
}
