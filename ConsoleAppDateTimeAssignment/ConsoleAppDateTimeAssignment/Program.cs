using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDateTimeAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime timeoftoday =  DateTime.Now; //Prints the current date and time to the console.
            Console.WriteLine(timeoftoday.ToString("MM/dd/yyyy hh:mm tt"));
            Console.ReadLine();

            Console.WriteLine("Please enter a number."); //Asks the user for a number.
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hours it will be: ", input);
            Console.WriteLine(timeoftoday.AddHours(input)); //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.ReadLine();

        }
    }
}
