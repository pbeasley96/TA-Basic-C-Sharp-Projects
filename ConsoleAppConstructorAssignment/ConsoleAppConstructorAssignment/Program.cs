using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructorAssignment
{
    public class Constructor
    {
        public string Name;
        public int Age;
        public Constructor():this("Phillip",27) //Create a const variable.
        {
            Console.WriteLine("This is the Constructor Assignment");
        }
        public Constructor(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            Console.WriteLine("Student's name is: {0} and he is: {1} years old.", Name, Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var newConstuctor = new Constructor(); //Create a variable using the keyword “var.”
            Console.ReadLine(); //Output result, chaining two constructors together.
        }
    }
}
