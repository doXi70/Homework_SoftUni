using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_T10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(1);

            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
