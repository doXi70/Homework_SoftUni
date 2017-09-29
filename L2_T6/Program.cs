using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_T6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
