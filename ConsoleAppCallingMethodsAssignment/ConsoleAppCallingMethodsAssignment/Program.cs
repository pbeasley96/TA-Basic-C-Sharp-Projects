using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please select a number you want to do Math Operations on."); //Ask the user what number they want to do the math operations on.
            Console.ReadLine();

            Console.WriteLine("Select a number to add."); //Ask the User what number they want to add the first number by.

            Math mathAdd = new Math();  //Call each method in turn, passing the user input to the method.
            int input = Convert.ToInt32(Console.ReadLine());
            int resultOfMethod = mathAdd.Add(input);
            Console.WriteLine(resultOfMethod);  //Display the returned integer to the screen. The process is repeated for the next inputs
            Console.ReadLine();


            Console.WriteLine("Please select a number you want to do Math Operations on.");
            Console.ReadLine();

            Console.WriteLine("Select a number to multiply.");
            Math mathMultiply = new Math();
            int input1 = Convert.ToInt32(Console.ReadLine());
            int resultOfMethod2 = mathMultiply.Multiply(input1);
            Console.WriteLine(resultOfMethod2);
            Console.ReadLine();


            Console.WriteLine("Please select a number you want to do Math Operations on.");
            Console.ReadLine();

            Console.WriteLine("Select a number to divide by.");
            Math mathDivide = new Math();
            int input2 = Convert.ToInt32(Console.ReadLine());
            int resultOfMethod3 = mathDivide.Divide(input2);
            Console.WriteLine(resultOfMethod3);
            Console.ReadLine();

        }
    }
}
