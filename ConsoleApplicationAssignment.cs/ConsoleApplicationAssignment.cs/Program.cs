using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print Intro
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Print Person 1 and 2 details
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("23.50" + hourlyRate1);
            Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hoursWorked1 = Console.ReadLine();
            Console.WriteLine("40" + hoursWorked1);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("18.50" + hourlyRate2);
            Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            Console.WriteLine("32" + hoursWorked2);
            Console.ReadLine();
            
            //Print Annual salary
            Console.WriteLine("Annual Salary of Person 1");
            string annualRate1 = Console.ReadLine();
            Console.WriteLine("48,000" + annualRate1);
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 2");
            string annualRate2 = Console.ReadLine();
            Console.WriteLine("31,000" + annualRate2);
            Console.ReadLine();

            //Print True or False Statment
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            bool trueOrFalse = 48000 > 31000;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}
