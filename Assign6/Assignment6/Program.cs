using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a jagged array to store the scores of three students
        int[][] studentScores = new int[3][];

        // Initialize the jagged array with the scores
        studentScores[0] = new int[] { 85, 92, 78 };
        studentScores[1] = new int[] { 90, 87, 93, 89 };
        studentScores[2] = new int[] { 76, 88 };

        // Print the scores of each student using nested loops
        Console.WriteLine("Student Scores:");
        for (int i = 0; i < studentScores.Length; i++)
        {
            Console.Write("Student {0}: ", i + 1);
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                Console.Write("{0} ", studentScores[i][j]);
            }
            Console.WriteLine();
        }

        // Calculate and print the average score for each student
        Console.WriteLine("\nAverage Scores:");
        for (int i = 0; i < studentScores.Length; i++)
        {
            double sum = 0;
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                sum += studentScores[i][j];
            }
            double average = sum / studentScores[i].Length;
            Console.WriteLine("Student {0}: {1}", i + 1, average);
        }

        // Calculate and print the average score for all students combined
        Console.WriteLine("\nAverage Score for All Students:");
        double totalSum = 0;
        double totalCount = 0;
        for (int i = 0; i < studentScores.Length; i++)
        {
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                totalSum += studentScores[i][j];
                totalCount++;
            }
        }
        double totalAverage = totalSum / totalCount;
        Console.WriteLine(totalAverage);
        Console.ReadKey();
    }
}