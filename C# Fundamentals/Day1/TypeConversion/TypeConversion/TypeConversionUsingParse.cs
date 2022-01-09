using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class TypeConversionUsingParse
    {
        static void Main(string[] args)
        {

            string n = "100";

            // converting string to int type
            int a = int.Parse(n);
            Console.WriteLine("Original string value: " + n);
            Console.WriteLine("Converted int value: " + a);
            Console.ReadLine();
        }
    }
}
