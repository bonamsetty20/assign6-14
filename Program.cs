using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConappAssign6_14_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize the studentScores array
            int[][] studentScores = new int[][]
        {
            new int[] { 85, 92, 78 },
            new int[] { 90, 87, 93, 89 },
            new int[] { 76, 88 }
        };
            //print the scores if each student
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.WriteLine($"Student {i + 1} scores:");

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.WriteLine(studentScores[i][j]);
                }

                Console.WriteLine();
            }

            // average score for each student and print results
            for (int i = 0; i < studentScores.Length; i++)
            {
                double sum = 0;

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }

                double average = sum / studentScores[i].Length;
                Console.WriteLine($"Average score for Student {i + 1}: {average}");
            }

            //average score if all students and print result
            double totalSum = 0;
            int totalScores = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalScores++;
                }
            }

            double totalAverage = totalSum / totalScores;
            Console.WriteLine($"Average score for all students combined: {totalAverage}");
            Console.ReadKey();
        }
    }
}
