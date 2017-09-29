using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(odd);
                sum += odd;
                odd += 2;

            }
            Console.WriteLine("Sum is: "+ sum);
        }
    }
}
