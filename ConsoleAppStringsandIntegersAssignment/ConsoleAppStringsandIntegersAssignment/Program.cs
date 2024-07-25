using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsandIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                List<int> numDivide = new List<int>() { 10, 20, 30 }; //Create a list of integers.

                Console.WriteLine("Please select a number to divide by."); //Ask the user for a number to divide each number in the list by.

                int input = Convert.ToInt32(Console.ReadLine());

                foreach (int element in numDivide) //Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
                {
                    Console.WriteLine(element / input);
                }
                Console.ReadLine();
            }
            catch (FormatException ex) //Put the loop in a try/catch block and print a message to display the error message to the screen.
            {
                Console.WriteLine("Please type a whole number."); //Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            Console.ReadLine();
        }
    }
}
