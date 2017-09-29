using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_T12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int MaxBoundary = int.Parse(Console.ReadLine());

            int TotalSum = 0;
            int number = 0;
            int TotalCombinations = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    number = i * j;
                    TotalSum += number * 3;
                    TotalCombinations++;

                    if (TotalSum >= MaxBoundary)
                    {
                        Console.WriteLine($"{TotalCombinations} combinations");
                        Console.WriteLine($"Sum: {TotalSum} >= {MaxBoundary}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{TotalCombinations} combinations");
            Console.WriteLine($"Sum: {TotalSum}");
        }
    }
}
