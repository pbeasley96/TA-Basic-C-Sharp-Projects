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
            List<Employee> empLambda = new List<Employee>();
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
                    empNames2.Add(employee);
                    Console.WriteLine("Employee names: {0} {1} {2}", employee.FirstName, employee.LastName, employee.ID);
                }
            }

            var employee1 = empNames.Where(e => e.FirstName == "Joe"); //Created another list of all employees with the first name “Joe” using a lambda expression.
            foreach (var value in employee1)
            {
                empLambda.Add(value);
                Console.WriteLine("Employee names: {0} {1} {2}", value.FirstName, value.LastName, value.ID);
            }
            
            var employeeID = empNames.Where(e => e.ID > 5); //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            foreach (var value1 in employeeID)
            {
                Console.WriteLine("Employee names with an ID rank over 5: {0} {1} {2}", value1.FirstName, value1.LastName, value1.ID);
            }
            Console.ReadLine();
        }
    }
}
