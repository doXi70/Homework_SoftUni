using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int StartFrom = int.Parse(Console.ReadLine());


            if (StartFrom <= 10)
            {
                for (int i = StartFrom; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
            else
            {
                Console.WriteLine($"{n} X {StartFrom} = {n * StartFrom}");
            }

        }
    }
}
