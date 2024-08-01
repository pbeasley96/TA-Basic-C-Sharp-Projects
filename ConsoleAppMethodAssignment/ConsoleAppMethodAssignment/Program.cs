using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodAssignment
{
    public class Math //Create a class.
    {
        public int Operation(int number, int number1 = 0) //In that class, create a method that takes two integers as parameters.
        {
            int value1 = number * number1;
            return value1;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number. You can select up to two numbers one at a time."); //Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

            Math newOperation = new Math(); //Call the method in the class, passing in the one or two numbers entered.
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number (optional, press Enter to skip):");
            string secondNumber = Console.ReadLine();

            int result;
            if (string.IsNullOrEmpty(secondNumber))
            {
                result = newOperation.Operation(input1);
            }
            else
            {
                int input2 = int.Parse(secondNumber);
                result = newOperation.Operation(input1, input2);
            }
            Console.ReadLine();
        }
    }
}
