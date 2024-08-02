using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassAssignment
{
    public class Math //Create a class.
    {
        public void Divide(int number) //In that class, create a void method that outputs an integer.
        {
            Console.WriteLine(number / 2);
        }
        public void ValueResult(out int result) //Create a method with output parameters.
        {
            Console.WriteLine("Enter value here: ");
            result = Convert.ToInt32(Console.ReadLine());
        }

        public void Divide(int number1, int number2) //Overload a method.
        {
            Console.WriteLine(number1 / number2);
        }

    }

    static class ClassStatic //Declare a class to be static.
    {
        public static string String = "Static Class";
     
    }


    class Program
    {
        static void Main(string[] args)
        {
            Math mathDivide = new Math(); //In the Main() method, instantiate that class.

            Console.WriteLine("Please enter a number."); //Have the user enter a number.
            int input = Convert.ToInt32(Console.ReadLine());
            mathDivide.Divide(input); //Call the method on that number. Display the output to the screen.
            Console.ReadLine();

            Math valueRes = new Math();
            int a;
            valueRes.ValueResult(out a);
            Console.WriteLine("Method with output Parameters, result of value is: {0}", a);
            Console.ReadLine();

            Math mathdivide = new Math();
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            mathdivide.Divide(input1, input2);
            Console.ReadLine();

            Console.WriteLine("This is a: {0} ", ClassStatic.String);
            Console.ReadLine();
        }
    }
}
