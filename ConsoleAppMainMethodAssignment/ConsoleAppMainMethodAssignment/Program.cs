using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer intAdd = new Integer();
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intAdd + input);
            Console.ReadLine();
        }
    }
}
