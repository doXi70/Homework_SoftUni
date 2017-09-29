using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_T7
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;

            while (true)
            {
                string ingredient = Console.ReadLine();

                if (ingredient.Equals("Bake!"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    count++;
                }

            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
