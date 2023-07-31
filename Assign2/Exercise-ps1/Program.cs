using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_ps1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example using TryParse method to convert string to int
            string intString = "956";
            int intValue;
            if (int.TryParse(intString, out intValue))
            {
                Console.WriteLine("TryParse successful. Converted integer value: " + intValue);
            }
            else
            {
                Console.WriteLine("TryParse failed. Invalid input string.");
            }

            // Example using Convert method to convert string to double
            string doubleString = "9.14";
            try
            {
                double doubleValue = Convert.ToDouble(doubleString);
                Console.WriteLine("Convert successful. Converted double value: " + doubleValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Convert failed. Input value is too large or too small.");
            }

            // Example using Parse method to convert string to decimal
            string decimalString = "20.25";
            try
            {
                decimal decimalValue = decimal.Parse(decimalString);
                Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Parse failed. Input value is too large or too small.");
            }
            Console.ReadKey();
        }
    }
}
