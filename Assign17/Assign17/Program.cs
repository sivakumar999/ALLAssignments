using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign17
{
    internal class Program
    {
        static void Main(string[] args)
        {

           


            while (true)
            {
                Console.WriteLine("Select the shape:");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");

                int choice = int.Parse(Console.ReadLine());

                Shape shape = null;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the radius of the Circle:");
                        double circleRadius = double.Parse(Console.ReadLine());
                        shape = new Circle(circleRadius);
                        break;

                    case 2:
                        Console.WriteLine("Enter the width of the Rectangle:");
                        double rectangleWidth = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of the Rectangle:");
                        double rectangleHeight = double.Parse(Console.ReadLine());
                        shape = new Rectangle(rectangleWidth, rectangleHeight);
                        break;

                    case 3:
                        Console.WriteLine("Enter the length of side A of the Triangle:");
                        double triangleSideA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the length of side B of the Triangle:");
                        double triangleSideB = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the length of side C of the Triangle:");
                        double triangleSideC = double.Parse(Console.ReadLine());
                        shape = new Triangle(triangleSideA, triangleSideB, triangleSideC);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        continue; 
                }

                
                shape.PrintInfo();

                
                Console.WriteLine("Area: " + shape.Area + ", Perimeter: " + shape.Perimeter);

                Console.WriteLine("Do you want to continue? (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "y")
                    break; 
            }

            Console.ReadKey();

        }
    }
}
