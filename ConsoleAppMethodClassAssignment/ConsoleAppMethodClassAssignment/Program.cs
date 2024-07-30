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
            Console.WriteLine(value2);
        }

        internal int MathVal()
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Math mathVal = new Math(); //In the Main() method of the console app, instantiate the class.
            int resultofMethod = mathVal.MathVal();
            Console.WriteLine(resultofMethod);
            Console.ReadLine();

            Math mathParameters = new Math(); //Call the method in the class, passing in two numbers.
            int input1 = 50;
            int input2 = 50;
            int resultOFMethod = mathParameters.MathVal(input1, input2);
            Console.WriteLine(resultOFMethod);
            Console.ReadLine();

            Math mathPass = new Math(); //Call the method in the class, specifying the parameters by name.
            int methodPass = mathPass.MathVal(value, value2);
            Console.WriteLine(methodPass);
            Console.ReadLine();
        }
    }
}
