using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLambdaAssignment
{
    public class Employee //Create an Employee class.
    {
        public Employee(string firstname, string lastname, int id)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.id = id;
        }
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
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        internal void Add(Employee employee2)
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empNames = new List<Employee>(); //Create a list of at least 10 employees. At least two employees should have the first name “Joe”.
            List<Employee> empNames2 = new List<Employee>();
            List<Employee> empLambda = empNames.Where(e => e.ID >= 5).ToList();
            empNames.Add(new Employee("Joe", "Madureira", 1));
            empNames.Add(new Employee("Akira", "Toriyama", 2));
            empNames.Add(new Employee("Yusuke", "Murata", 3));
            empNames.Add(new Employee("David", "Marquez", 4));
            empNames.Add(new Employee("Jorge", "Jimenez", 5));
            empNames.Add(new Employee("Jim", "Lee", 6));
            empNames.Add(new Employee("Kohei", "Horikoshi", 7));
            empNames.Add(new Employee("Masashi", "Kishimoto", 8));
            empNames.Add(new Employee("Tite", "Kubo", 9));
            empNames.Add(new Employee("Joe", "Michaels", 10));

            foreach(var employee in empNames) //Using a foreach loop, created a new list of all employees with the first name “Joe”.
            {
                if (employee.FirstName == "Joe")
                {
                    empNames.AddRange(empNames2);
                }
            }
            foreach (Employee employee1 in empLambda) //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            {
                Console.WriteLine($"{employee1.FirstName} has an ID number greater than 5.");
            }
            Console.ReadLine();
        }
    }
}
