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
            public static bool operator == () 
            {
              
            }
            public static bool operator !=()
            {

            }
        }

        static void Main(string[] args)
        {
        }
    }
}
