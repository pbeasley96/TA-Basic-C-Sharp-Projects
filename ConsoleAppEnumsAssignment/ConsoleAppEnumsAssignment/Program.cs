using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEnumsAssignment
{
    class Program
    {
        public enum Week //Create an enum for the days of the week.
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thrusday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            try //Wrap the above statement in a try/catch block.
            {
                Console.WriteLine("Please select a day within the week."); //Prompt the user to enter the current day of the week.
                string input = Console.ReadLine();
                Week week; //Assign the value to a variable of that enum data type you just created.

                if (Enum.TryParse<Week>(input, out week))
                {
                    Console.WriteLine("The day you have selected is: " + input);
                }
                else
                {
                    throw new FormatException("Please enter an actual day of the week.");
                }
            }
            catch (FormatException cat)
            {
                Console.WriteLine(cat.Message);
            }
            Console.ReadLine();
        }
    }
}
