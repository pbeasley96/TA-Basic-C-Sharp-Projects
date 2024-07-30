using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodAssignment
{
    public class Math //Create a class.
    {
        public int Operation(int number) //In that class, create a method that takes two integers as parameters.
        {
            int value = number;
            return value;
        }
        public int OperationOptional(int number) //Make one of them optional. Have the method do a math operation and return an integer result.
        {
            int value = number + 50;
            if (value != 0 && value != int.)
            {
                return value;
            }
            else
            {
                return ;
            }

        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number. You can select up to two numbers one at a time."); //Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

            Math newOperation = new Math(); //Call the method in the class, passing in the one or two numbers entered.
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());

            int resultofMethod1 = newOperation.Operation(input1);
            int resultofMethod2 = newOperation.OperationOptional(input2);

            Console.WriteLine(resultofMethod1 + 50);
            Console.WriteLine(resultofMethod1 + resultofMethod2);
            Console.ReadLine();
        }
    }
}
