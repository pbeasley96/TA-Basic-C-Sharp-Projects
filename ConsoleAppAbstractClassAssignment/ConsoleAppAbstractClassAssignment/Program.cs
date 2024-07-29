using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClassAssignment
{
    abstract class Person //Create an abstract class called Person with two properties: string firstName and string lastName.
    {
        public abstract void EmpName(string fName, string lName);

        public void SayName() //Give it the method SayName().
        {
            Console.WriteLine("Name: [full name]");
        }
        public class Employee : Person //Create another class called Employee and have it inherit from the Person class.
        {
            public override void EmpName(string fName, string lName)
            {
                throw new NotImplementedException();
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Person employeeName = new Person(); //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. 
            string input = "Sample";
            string input2 = "Student";
            string resultofAbstract = Convert.ToString(input + input2);
            employeeName.SayName(); //Call the SayName() method on the object.
            Console.WriteLine(resultofAbstract);

        }
    }
}
