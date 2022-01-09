using System;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("The string couldn't converted to be a boolean");
            }
        }
    }
}
