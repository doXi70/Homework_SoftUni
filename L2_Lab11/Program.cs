using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumber = -1;

            do
            {

                oddNumber = int.Parse(Console.ReadLine());

                if (oddNumber % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");   
                }

            } while (oddNumber % 2 == 0);

            Console.WriteLine("The number is: " + Math.Abs(oddNumber));
        }
    }
}
