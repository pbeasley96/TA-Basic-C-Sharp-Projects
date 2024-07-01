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
            Console.WriteLine("" + yourAge);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            string yourAnswer = Console.ReadLine();
            Console.WriteLine("" + yourAnswer);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();
            Console.WriteLine("" + yourTickets);
            Console.ReadLine();

            int num1 = 15;
            int num2 = 3;

            Console.WriteLine("Is this person qualified?");
            Console.ReadLine();
            bool isQualified = (yourAge >= num1 && yourAnswer == "No" && yourTickets < num2);
            Console.WriteLine(isQualified);

        }
    }
}
