using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassAssignment
{
    public class Math 
    {
        public int Divide(int number)
        {
            number = 50;
            int value = number / 2;
            return value;
        }
        public void PrintedEquation(int value)
        {
            Console.WriteLine("{0}", value);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Math mathDivide = new Math();
            ex.Divide();
            ex.PrintedEquation();
        }
    }
}
