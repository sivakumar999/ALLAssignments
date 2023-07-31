using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3exerecise_ps_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert a string to an integer using TryParse
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                int result = number * 5;
                Console.WriteLine($"The result is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Convert a string to a DateTime object using Convert
            Console.WriteLine("Enter a date (dd/mm/yyyy): ");
            string dateInput = Console.ReadLine();
            try
            {
                DateTime date = Convert.ToDateTime(dateInput);
                DateTime newDate = date.AddMonths(-1);
                Console.WriteLine($"One month ago was: {newDate.ToShortDateString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid date in the format dd/mm/yyyy.");
            }

            // Convert a string to a TimeSpan object using Parse
            Console.WriteLine("Enter a time (hh:mm:ss): ");
            string timeInput = Console.ReadLine();
            try
            {
                TimeSpan time = TimeSpan.Parse(timeInput);
                TimeSpan newTime = time.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Two hours later will be: {newTime.ToString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid time in the format hh:mm:ss.");
            }
            Console.ReadKey();
        }
    }
}
