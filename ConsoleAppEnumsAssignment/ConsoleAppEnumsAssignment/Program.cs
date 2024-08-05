using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEnumsAssignment
{
    public class Week {
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }; //Create an enum for the days of the week.

        public static void Main()
        {
            Console.WriteLine("Please select a day in the week."); //Prompt the user to enter the current day of the week.
            Console.ReadLine();
            foreach (string weekDay in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine("You've selected: ", weekDay, Enum.Parse(typeof(Days)));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
