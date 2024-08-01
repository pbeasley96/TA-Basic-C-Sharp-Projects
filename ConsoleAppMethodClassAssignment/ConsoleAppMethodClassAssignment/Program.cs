using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodClassAssignment
{
    class Math //Create a class.
    {
        public void MathVal(int value, int value2) //In that class, create a void method that takes two integers as parameters.
        {
            int result = value + 50;
            Console.WriteLine(result);
            Console.WriteLine(value2);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Math mathVal = new Math(); //In the Main() method of the console app, instantiate the class.

            int input1 = 150;
            int input2 = 25;
            mathVal.MathVal(input1, input2); //Call the method in the class, passing in two numbers. 
            Console.ReadLine();

            Math mathParameters = new Math(); //Call the method in the class, specifying the parameters by name.
            mathParameters.MathVal(value2: 25, value: 50);
            Console.ReadLine();
        }
    }
}
