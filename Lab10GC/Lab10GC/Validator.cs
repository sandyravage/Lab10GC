using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10GC
{
    class Validator
    {
        public string YesNoChecker(string input)
        {
            while (input != "y" && input != "n")
            {
                Console.WriteLine("Invalid selection. Please enter \"y\" or \"n\"");
                input = Console.ReadLine();
            }
            return input;
        }
        public double NumberValidator(string input)
        {
            double num;
            while (!double.TryParse(input, out num) || num <= 0)
            {
                Console.WriteLine("Invalid selection. Please enter a positive number.");
                input = Console.ReadLine();
            }
            return num;
        }
    }
}
