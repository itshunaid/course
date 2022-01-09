using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class ImplicitTypeConversion
    {
        static void Main(string[] args)
        {
            int numInt = 500;

            // get type of numInt
            Type n = numInt.GetType();

            // Implicit Conversion
            double numDouble = numInt;

            // get type of numDouble
            Type n1 = numDouble.GetType();

            // Value before conversion
            Console.WriteLine("numInt value: " + numInt);
            Console.WriteLine("numInt Type: " + n);

            // Value after conversion
            Console.WriteLine("numDouble value: " + numDouble);
            Console.WriteLine("numDouble Type: " + n1);
            Console.ReadLine();
        }
    }
}
