using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLambdaAssignment
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<string> empNames = new List<string>();
            empNames[0] = new Employee() { Id = 1, FirstName = "Joe", LastName = "Madureira" };
            empNames[1] = new Employee() { Id = 2, FirstName = "Akira", LastName = "Toriyama" };
            empNames[2] = new Employee() { Id = 3, FirstName = "Yusuke", LastName = "Murata" };
            empNames[3] = new Employee() { Id = 4, FirstName = "David", LastName = "Marquez" };
            empNames[4] = new Employee() { Id = 1, FirstName = "Jorge", LastName = "Jimenez" };
            empNames[5] = new Employee() { Id = 2, FirstName = "Jim", LastName = "Lee" };
            empNames[6] = new Employee() { Id = 3, FirstName = "Kohei", LastName = "Horikoshi" };
            empNames[7] = new Employee() { Id = 4, FirstName = "Masashi", LastName = "Kishimoto" };
            empNames[8] = new Employee() { Id = 1, FirstName = "Tite", LastName = "Kubo" };
            empNames[9] = new Employee() { Id = 2, FirstName = "Joe", LastName = "Michaels" };

            foreach (var item in empNames)
            {
                if (empNames.IndexOf(item) = "Joe")
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
