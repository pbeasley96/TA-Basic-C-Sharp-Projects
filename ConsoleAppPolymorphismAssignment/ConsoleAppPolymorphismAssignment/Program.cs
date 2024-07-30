using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolymorphismAssignment
{
    interface IQuittable //Create an interface called IQuittable and have it define a void method called Quit().
    {
        void IQuit();
    }

    class Employee : IQuittable //Employee Class will inherit that interface and implement the Quit() method.
    {
        public void IQuit()
        {
            Console.WriteLine("The Employee says: I Quit!");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee(); //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            myEmployee.IQuit();
            Console.ReadLine();
        }
    }
}
