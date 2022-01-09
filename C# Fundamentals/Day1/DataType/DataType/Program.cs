using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region C# Primitive Data Types
            //Variables in C# are broadly classified into two types: 
            //Value types and Reference types.
            //In this tutorial we will be discussing about primitive (simple) data types
            //which is a subclass of Value types.

            //Reference types will be covered in later tutorials.
            //However, if you want to know more about variable types,
            //visit C# Types and variables (official C# docs).

            //Boolean(bool)
            //Boolean data type has two possible values: true or false
            //Default value: false
            //Boolean variables are generally used to check conditions
            //such as in if statements, loops, etc.
            bool isValid = true;
            Console.WriteLine(isValid);

            //Signed Integral
            //These data types hold integer values(both positive and negative). 
            //Out of the total available bits, one bit is used for sign.

            //1. sbyte
            //Size: 8 bits
            //Range: -128 to 127.
            //Default value: 0
            sbyte level = 23;
            Console.WriteLine(level);

            //2. short
            //Size: 16 bits
            //Range: -32,768 to 32,767
            //Default value: 0
            short value = -1109;
            Console.WriteLine(value);

            //3. int
            //Size: 32 bits
            //Range: -231 to 231 - 1
            //Default value: 0
            int score = 51092;
            Console.WriteLine(score);

            //4. long
            //Size: 64 bits
            //Range: -263 to 263 - 1
            //Default value: 0L[L at the end represent the value is of long type]
            long range = -7091821871L;
            Console.WriteLine(range);

            //Unsigned Integral
            //These data types only hold values equal to or greater than 0.
            //We generally use these data types to store values when we are sure, 
            //we won't have negative values.

            //1. byte
            //Size: 8 bits
            //Range: 0 to 255.
            //Default value: 0
            byte age = 62;
            Console.WriteLine(age);

            //2. ushort
            //Size: 16 bits
            //Range: 0 to 65,535
            //Default value: 0
            ushort valueNumber = 42019;
            Console.WriteLine(valueNumber);

            //3. uint
            //Size: 32 bits
            //Range: 0 to 232 - 1
            //Default value: 0
            uint totalScore = 1151092;
            Console.WriteLine(totalScore);

            //4. ulong
            //Size: 64 bits
            //Range: 0 to 264 - 1
            //Default value: 0
            ulong rangeValue = 17091821871L;
            Console.WriteLine(rangeValue);

            //Floating Point
            //These data types hold floating point values
            //i.e.numbers containing decimal values.
            //For example, 12.36, -92.17, etc.

            //1. float
            //Single - precision floating point type
            //Size: 32 bits
            //Range: 1.5 × 10−45 to 3.4 × 1038
            //Default value: 0.0F[F at the end represent the value is of float type]
            float number = 43.27F;
            Console.WriteLine(number);

            //2. double
            //Double-precision floating point type. 
            //What is the difference between single and double precision floating point?
            //Size: 64 bits
            //Range: 5.0 × 10−324 to 1.7 × 10308
            //Default value: 0.0D [D at the end represent the value is of double type]

            double valueRange = -11092.53D;
            Console.WriteLine(valueRange);

            //Character (char)
            //It represents a 16 bit unicode character.
            //Size: 16 bits
            //Default value: '\0'
            //Range: U+0000 ('\u0000') to U+FFFF ('\uffff')

            char ch1 = '\u0042';
            char ch2 = 'x';
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);

            //Decimal
            //Decimal type has more precision and a smaller range as compared to floating point types //(double and float). So it is appropriate for monetary calculations.
            //Size: 128 bits
            //Default value: 0.0M [M at the end represent the value is of decimal type]
            //Range: (-7.9 x 1028 to 7.9 x 1028) / (100 to 28)
            decimal bankBalance = 53005.25M;
            Console.WriteLine(bankBalance);
            #endregion  

            Console.ReadKey();
        }
    }
}
