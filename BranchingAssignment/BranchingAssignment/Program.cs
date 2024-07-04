using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight.");
            string itemWeight = Console.ReadLine();
            Console.WriteLine("Item Weight: " + itemWeight);
            if (Convert.ToDouble(itemWeight) > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();

            Console.WriteLine("Please enter the package width.");
            string itemWidth = Console.ReadLine();
            Console.WriteLine("Item Width: " + itemWidth);
            if (Convert.ToDouble(itemWidth) > 50)
            {
                Console.WriteLine("Package too wide to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();

            Console.WriteLine("Please enter the package height.");
            string itemHeight = Console.ReadLine();
            Console.WriteLine("Item Height: " + itemHeight);
            if (Convert.ToDouble(itemHeight) > 50)
            {
                Console.WriteLine("Package too tall to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();

            Console.WriteLine("Please enter the package length.");
            string itemLength = Console.ReadLine();
            Console.WriteLine("Item Length: " + itemLength);
            if (Convert.ToDouble(itemLength) > 50)
            {
                Console.WriteLine("Package too long to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();

            Console.WriteLine("Your estimated total for shipping this package is:");
            double totalProduct = Convert.ToDouble(itemWidth) * Convert.ToDouble(itemHeight) * Convert.ToDouble(itemLength) * Convert.ToDouble(itemWeight) / 100;
            Console.WriteLine("$" + totalProduct);
            Console.ReadLine();

            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
