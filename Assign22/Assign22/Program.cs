using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assign22
{
    internal class Program
    {

        static void Main()
        {
            Source source = new Source
            {
                Id = 11,
                Name = "siva",
                Age = 30


            };
            /*Console.WriteLine("Enter a id :");
            source.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a name :");
            source.Name = Console.ReadLine();
            Console.WriteLine("Enter a age :");
            source.Age = int.Parse(Console.ReadLine());*/

            Destination destination = new Destination();

            PropertyMaping.MapProperties(source, destination);

            // Display the values in the Source class
            Console.WriteLine("Source Class Properties:");
            Console.WriteLine($"Id: {source.Id}");
            Console.WriteLine($"Name: {source.Name}");
            Console.WriteLine($"Age: {source.Age}");

            Console.WriteLine();

            // Display the values in the Destination class
            Console.WriteLine("Destination Class Properties:");
            Console.WriteLine($"Id: {destination.Id}");
            Console.WriteLine($"Name: {destination.Name}");
            Console.WriteLine($"Salary: {destination.Salary}");
            Console.WriteLine($"Department: {destination.Department}");

            Console.ReadKey();
        }
    }
}
