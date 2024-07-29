using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassAssignment
{
    public class Math //Create a class.
    {
        public void Divide(int number, out int result) //In that class, create a void method that outputs an integer.
        {
            result = number / 2; //Have the method divide the data passed to it by 2.
        }
        public void DivideResult()
        {
            int result;
            Divide(50, out result);
            Console.WriteLine("Divided result is: " + result);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Math mathDivide = new Math(); //In the Main() method, instantiate that class.
            int resultofMethod = mathDivide.DivideResult();
            Console.WriteLine(resultofMethod);
        }
    }
}
