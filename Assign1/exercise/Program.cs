using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string EmployeeName;
            char EmployeeGender;
            decimal EmployeeSalary;
            DateTime DOJ;
            Console.WriteLine("Id: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee Name: ");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Employee Gender: ");
            EmployeeGender = char.Parse(Console.ReadLine());
            Console.WriteLine("DOJ: ");
            DOJ = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Employee Salary: ");
            EmployeeSalary = decimal.Parse(Console.ReadLine());
            if (EmployeeSalary > 900000)
            {
                Console.WriteLine("You will have to pay 30% tax");
            }
            else
            {
                Console.WriteLine("You will have to pay 15% tax");
            }
            /*Console.WriteLine("ID: \t" + id + "\n Employee Name: " + EmployeeName + "\n Employee Gender: \t" + EmployeeGender +
                "\n  Employee Salary: \t" + EmployeeSalary + "\nDOJ: \t" + DOJ);*/
            Console.WriteLine("Id\tEmployee Name\tEmployee Gender\t\tEmployee Salary\tDoj");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"{id}\t{EmployeeName}\t\t{EmployeeGender}\t\t\t{EmployeeSalary}\t\t{DOJ:dd/MM/yyyy}");

            decimal taxRate;
            if (EmployeeSalary > 90000)
            {
                taxRate = 0.3m;
            }
            else
            {
                taxRate = 0.15m;
            }
            decimal taxAmount = EmployeeSalary * taxRate;

            Console.WriteLine($"\nYou have to pay some tax is : {taxAmount}.");
            Console.ReadLine();

        }
    }

}

