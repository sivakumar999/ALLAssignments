using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAssign14
{
    internal class Program
    {



        /*public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers");
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Numbers are :");
            Print(num);

            Console.WriteLine("Array without Sort");
            Print(num);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(num);
            stopwatch.Stop();
            Console.WriteLine("Array after bubble sort");
            Print(num);
            Console.WriteLine($" array size is {num.Length} Time Taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();*/


        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers for Bubble Sort");
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Numbers are :");
            Print(num);

            Console.WriteLine("Print Array without Sort");
            Print(num);
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            BubbleSort(num);
            s1.Stop();
            Console.WriteLine("print Array after bubble sort");
            Print(num);
            Console.WriteLine($"Arraysize is {num.Length} Time Taken for bubble sort {s1.Elapsed.TotalMilliseconds} milliseconds");
            Console.WriteLine("==========================");
            Console.WriteLine("Enter numbers for insertion sort");
            int[] num1 = new int[5];
            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Numbers are :");
            Print(num1);
            Console.WriteLine("Print Array without Sort");
            Print(num1);
            Stopwatch s2 = new Stopwatch();
            s2.Start();
            InsertionSort(num1);
            s2.Stop();
            Console.WriteLine("print Array after Insertion sort");
            Print(num1);
            Console.WriteLine($"Arraysize is {num1.Length} Time Taken for insertion sort {s2.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();

        }

    }


    
}
