using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodAssignment
{
    public class Number
    {
        public int Add(int number, int number2)
        {
            int value1 = number + 50;
            int value2 = number + number2 + 50;
            return value1;
            return value2;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number. You can select up to two numbers one at a time.");
            Console.ReadLine();

            Number numberMath = new Number();
            int input1 = Convert.ToInt32(Console.ReadLine());
            int resultofInput1 = numberMath.Add(input1);
        }
    }
}
