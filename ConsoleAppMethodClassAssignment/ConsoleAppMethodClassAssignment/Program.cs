using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodClassAssignment
{
    class Math //Create a class.
    {
        public void MathVal(int value, int value2, out int result) //In that class, create a void method that takes two integers as parameters.
        {
            result = value + value2;
        }
        public void Display() //Have the method do a math operation on the first integer and display the second integer to the screen. 
        {
            int result;
            MathVal(50, 50, out result);
            Console.WriteLine("Result:" + result);
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
        }
    }
}
