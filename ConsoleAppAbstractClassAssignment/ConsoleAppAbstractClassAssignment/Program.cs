using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClassAssignment
{
    abstract class Person //Create an abstract class called Person with two properties: string firstName and string lastName.
    {
        public abstract string FName { get; set; }
        public abstract string LName { get; set; }
        public abstract void SayName();
    }

    class Employee : Person //Create another class called Employee and have it inherit from the Person class.
    {
        public override string FName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string LName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override void SayName() //Implement the SayName() method inside of the Employee class.
        {
            Console.WriteLine("Name: ");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeName = new Employee(); //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. 
            string input = "Sample";
            string input2 = "Student";
            string resultofAbstract = Convert.ToString(input + " " + input2);
            employeeName.SayName(); //Call the SayName() method on the object.
            Console.WriteLine(resultofAbstract);
            Console.ReadLine();
        }
    }
}
