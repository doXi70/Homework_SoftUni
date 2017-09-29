using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            int GroupSize = int.Parse(Console.ReadLine());
            string Package = Console.ReadLine();
            double PricePerPerson = 0;

            if (GroupSize <= 50)
            {
                if (Package.Equals("Normal"))
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {PricePerPerson = 2850 / (double)GroupSize:F2}$");
                }
                else if (Package.Equals("Gold"))
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {PricePerPerson = 2925 / (double)GroupSize:F2}$");
                }
                else
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {PricePerPerson = 2975 / (double)GroupSize:F2}$");
                }
            }
            else if (GroupSize <= 100)
            {
                if (Package.Equals("Normal"))
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {PricePerPerson = 5225 / (double)GroupSize:F2}$");
                }
                else if (Package.Equals("Gold"))
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {PricePerPerson = 5175 / (double)GroupSize:F2}$");
                }
                else
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {PricePerPerson = 5100 / (double)GroupSize:F2}$");
                }
            }
            else if (GroupSize <= 120)
            {
                if (Package.Equals("Normal"))
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {PricePerPerson = 7600 / (double)GroupSize:F2}$");
                }
                else if (Package.Equals("Gold"))
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {PricePerPerson = 7425 / (double)GroupSize:F2}$");
                }
                else
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {PricePerPerson = 7225 / (double)GroupSize:F2}$");
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
