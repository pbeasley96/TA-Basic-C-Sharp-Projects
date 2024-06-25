using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro for Student Daily Report
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //Questions for Student Daily Report
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You are on the " + courseName + " course.");
            Console.ReadLine();

            Console.WriteLine("What page are you on?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Page number: " + pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer “Yes” or “No.”");
            string yourAnswer = Console.ReadLine();
            Console.WriteLine("Your answer: " + yourAnswer);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();
            Console.WriteLine("Reponse: " + yourExperience);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("Response: " + yourFeedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            Console.WriteLine("Hours Studied: " + studyHours);
            Console.ReadLine();

            //End of Student Daily Report
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
