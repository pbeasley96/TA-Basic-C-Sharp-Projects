using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainMethodAssignment
{
    public class Integer
    {
        public Integer()
        {
            Add = new List<int>();
            List<int> intMath = new List<int>() { 1, 2, 3, 4, 5 };

            {
                int num = Convert.ToInt32(intMath);
            }

        }
            public List<int> Add { get; set; }
    }
}
