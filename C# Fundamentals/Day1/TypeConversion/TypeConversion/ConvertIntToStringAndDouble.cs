using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class ConvertIntToStringAndDouble
    {
        static void Main(string[] args)
        {

            // create int variable
            int num = 100;
            Console.WriteLine("int value: " + num);

            // convert int to string
            string str = Convert.ToString(num);
            Console.WriteLine("string value: " + str);

            // convert int to Double
            Double doubleNum = Convert.ToDouble(num);
            Console.WriteLine("Double value: " + doubleNum);

            Console.ReadLine();
        }
    }
}
