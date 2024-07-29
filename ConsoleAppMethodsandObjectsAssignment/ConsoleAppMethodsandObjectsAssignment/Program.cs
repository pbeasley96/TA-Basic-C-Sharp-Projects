using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodsandObjectsAssignment
{
    public class Person //Create a class called Person and give it two properties.
    {
        public string FirstName(string name)
        {
            string valueFirst = "Sample";
            return valueFirst;
        }
        public string LastName(string name)
        {
            string valueLast = "Student";
            return valueLast;
        }

        public void SayName() //A void method called SayName() that takes no parameters and simply writes the person's full name to the console.
        {
            Console.WriteLine("Name: [full name]");
        }
    }

    public class Employee  //Create another class called Employee and have it inherit from the Person class.
    {
        public int PropertyID(int number) // Give the Employee class a property called Id and have it be of data type int.
        {
            int valueID = number;
            return valueID;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person employeeName = new Person(); //Instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”.
            employeeName.SayName(); //Call the superclass method SayName() on the Employee object.
            Console.WriteLine(employeeName.FirstName + "" + employeeName.LastName);
        }
    }
}
