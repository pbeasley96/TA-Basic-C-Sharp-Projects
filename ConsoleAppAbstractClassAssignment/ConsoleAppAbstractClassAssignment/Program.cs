using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClassAssignment
{
    abstract class Person //Create an abstract class called Person with two properties: string firstName and string lastName.
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public abstract void SayName();
    }

    class Employee : Person //Create another class called Employee and have it inherit from the Person class.
    {
        public override void SayName() //Implement the SayName() method inside of the Employee class.
        {
            Console.WriteLine($"Name: {FName} {LName} ");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeName = new Employee { FName = "Sample", LName = "Student"}; //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. 
            employeeName.SayName(); //Call the SayName() method on the object.
            Console.ReadLine();
        }
    }
}
