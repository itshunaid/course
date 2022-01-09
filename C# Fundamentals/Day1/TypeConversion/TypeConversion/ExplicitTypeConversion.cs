using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class ExplicitTypeConversion
    {
        static void Main(string[] args)
        {

            double numDouble = 1.23;

            // Explicit casting
            int numInt = (int)numDouble;

            // Value before conversion
            Console.WriteLine("Original double Value: " + numDouble);

            // Value before conversion
            Console.WriteLine("Converted int Value: " + numInt);
            Console.ReadLine();
        }
    }
}
