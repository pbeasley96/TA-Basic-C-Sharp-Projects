using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodsandObjectsAssignment
{
    public class Person //Create a class called Person and give it two properties. One called FirstName, the other LastName.
    {
        private string firstname;
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        private string lastname;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public void SayName() //A void method called SayName() that takes no parameters and simply writes the person's full name to the console.
        {
            Console.WriteLine($"Name: {firstname} {lastname}");
        }
    }

    public class Employee : Person //Create another class called Employee and have it inherit from the Person class.
    {
        private int id; // Give the Employee class a property called Id and have it be of data type int.
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”.
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName(); //Call the superclass method SayName() on the Employee object.
            Console.ReadLine();
        }
    }
}
