using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;
            switch (proffesion)
            {
                case "Athlete":
                    Console.WriteLine($"The {proffesion} has to pay {price = 0.7 * quantity:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {proffesion} has to pay {price = 1 * quantity:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {proffesion} has to pay {price = 1.7 * quantity:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {proffesion} has to pay {price = 1.2 * quantity:F2}.");
                    break;
            }


        }
    }
}
