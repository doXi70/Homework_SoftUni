using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"{a}ml {name}:");
            Console.WriteLine($"{(a * b) / 100}kcal, {(a * c) / 100}g sugars");
        }
    }
}
