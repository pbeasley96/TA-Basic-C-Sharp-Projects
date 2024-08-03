using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperatorAssignment
{
    class Program
    {
        public class Employee //Create an Employee class with Id, FirstName and LastName properties. 
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
            private string id;
            public string ID
            {
                get { return id; }
                set { id = value; }
            }
            public static bool operator ==(Employee e1, Employee e2) //In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
            {
                if (e1 is null)
                    return e2 is null;
                return e1.Equals(e2);
            }
            public static bool operator !=(Employee e1, Employee e2)
            {
                return !(e1 == e2);
            }
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                return obj is Employee e2 ? (firstname == e2.firstname &&
                                            lastname == e2.lastname &&
                                            id == e2.id) : false;
            }
        }

        static void Main(string[] args)
        {
            Employee employeeID = new Employee(); //Instantiate two objects of the Employee class and assign values to their properties. 


        }
    }
}
