using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainMethodAssignment
{
    public class Math //Create a class.
    {
        private int mathadd;  // create a method that will take in an integer, create a math operation for this integer (addition), then return the answer as an integer.
        public int mathAdd
        {
            get { return mathadd; }
            set { mathadd = value; }
        }

        private int mathdecimal; //Add a second method to the class with the same name that will take in a decimal, create a different math operation for it (multiplication).
        public int mathDecimal
        {
            get { return mathdecimal; }
            set { mathdecimal = value; }
        }

        private int mathstring; //Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible (subtraction).
        public int mathString
        {
            get { return mathstring; }
            set { mathstring = value; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Math input1 = new Math(); //Instantiate the class and call the one method, passing in an integer.
            input1.mathAdd = 10;
            Console.WriteLine(input1.mathAdd + 10);
            Console.ReadLine(); // Display the result to the screen.

            decimal decimalVal;
            string intVal = "2.50";
            decimalVal = Convert.ToDecimal(intVal);
            Math input2 = new Math(); //instantiate the class and call the second method, passing in a decimal.
            input2.mathDecimal = Convert.ToInt16(decimalVal);
            Console.WriteLine(input2.mathDecimal * 10);
            Console.ReadLine(); //Display the result to the screen.


            string input = String.Empty;
            int x = Int32.Parse(input);
            Math input3 = new Math(); //Instantiate the class and call the third method, passing in a string that equates to an integer.
            input3.mathString = Convert.ToInt32(x);
            Console.WriteLine(input3.mathString - 2);
            Console.ReadLine(); //Display the result to the screen.
        }
    }
}
