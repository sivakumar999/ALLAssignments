using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruits = new ArrayList();
            Console.WriteLine("Enter fruits (one per line, empty line to stop):");
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                fruits.Add(input);
            }
            Console.WriteLine("Total number of elements: " + fruits.Count);
            Console.WriteLine("ArrayList contains 'date': " + fruits.Contains("date"));
            Console.WriteLine("Enter the fruit to insert:");
            string fruitToInsert = Console.ReadLine();
            Console.WriteLine("Enter the index to insert at:");
            int insertIndex = int.Parse(Console.ReadLine());
            fruits.Insert(insertIndex, fruitToInsert);
            Console.WriteLine("Enter the fruit to remove:");
            string fruitToRemove = Console.ReadLine();
            fruits.Remove(fruitToRemove);
            Console.WriteLine("Elements in the ArrayList:");
            foreach (object fruit in fruits)
            {
                Console.WriteLine(fruit);

            }
            Console.ReadKey();
        }
    }
}
