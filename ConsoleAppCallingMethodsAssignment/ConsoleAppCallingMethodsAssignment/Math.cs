using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCallingMethodsAssignment
{
    public class Math //Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
    {
        public int Add(int number)
        {
            int value = number + 10;
            return value;
        }

        public int Multiply(int number)
        {
            int value = number * 10;
            return value;
        }

        public int Divide(int number)
        {
            int value = number / 10;
            return value;
        }
    }
}
