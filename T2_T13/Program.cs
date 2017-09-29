using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_T13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int MagicalNumber = int.Parse(Console.ReadLine());
            int Combinations = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    Combinations++;
                    if (i + j == MagicalNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {MagicalNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{Combinations} combinations - neither equals {MagicalNumber}");
        }
    }
}
