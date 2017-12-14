using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSSCCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = SetNumber("Type your first number : ");
            double secondNumber = SetNumber("Type your second number: ");

            Console.WriteLine("What do you want to do with these numbers?");
            Console.WriteLine("1 = Add");
            Console.WriteLine("2 = Subtract");
            int temp = int.Parse(Console.ReadLine());
            if (temp == 1)
            {
                Program.Add(firstNumber, secondNumber);
            }
            else if (temp == 2)
            {
                Program.Subtract(firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Incorrect input. Shutting down");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            Console.WriteLine("The result of "+ firstNumber + "and "+ secondNumber +"is " + result);
        }

        private static void Subtract(double firstNumber, double secondNumber)
        {
            double result = 0;
            Console.WriteLine("The result of " + firstNumber + "and " + secondNumber + "is " + result);
        }

        private static double SetNumber(string outputText)
        {
            double parse;
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            if (!double.TryParse(tempInput, out parse))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return double.Parse(tempInput);
        }
    }
}
