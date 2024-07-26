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
            List<int> mathNumber = new List<int>() { 10, 20, 30, 40, 50 };


            Console.WriteLine("Please select a number you want to do Math Operations on."); //Ask the user what number they want to do the math operations on.

            Math mathAdd = new Math();  //Call each method in turn, passing the user input to the method.
            mathAdd.Add = Convert.ToInt32(mathNumber);
            Console.ReadLine();

            Console.WriteLine("Select a number to add."); //Ask the User what number they want to add the first number by.
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mathAdd.Add + input);  //Display the returned integer to the screen. The process is repeated for the next inputs

            Console.ReadLine();

            Console.WriteLine("Please select a number you want to do Math Operations on.");

            Math mathMultiply = new Math();
            mathMultiply.Multiply = Convert.ToInt32(mathNumber);
            Console.ReadLine();

            Console.WriteLine("Select a number to multiply.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mathMultiply.Multiply + input1);

            Console.ReadLine();

            Console.WriteLine("Please select a number you want to do Math Operations on.");

            Math mathDivide = new Math();
            mathDivide.Divide = Convert.ToInt32(mathNumber);
            Console.ReadLine();

            Console.WriteLine("Select a number to divide by.");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mathDivide.Divide + input2);

            Console.ReadLine();


        }
    }
}
