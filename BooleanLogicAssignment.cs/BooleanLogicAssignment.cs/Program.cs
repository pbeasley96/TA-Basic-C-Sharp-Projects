using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            Console.WriteLine("Age: " + yourAge);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            string yourAnswer = Console.ReadLine();
            Console.WriteLine("DUI's: " + yourAnswer);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();
            Console.WriteLine("Tickets: " + yourTickets);
            Console.ReadLine();

            Console.WriteLine("Is this person qualified?");
            Console.ReadLine();
            bool isQualified = (Convert.ToInt32(yourAge) >= 16 && yourAnswer == "No" && Convert.ToInt32(yourTickets) < 4);
            Console.WriteLine(isQualified);

        }
    }
}
