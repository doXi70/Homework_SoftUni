using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string TypeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (TypeOfDay.Equals("Weekday"))
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("12$");
                }
                else if (age >= 0 && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else if (age >= 0 && age <= 122)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (TypeOfDay.Equals("Weekend"))
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (age >= 0 && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else if (age >= 0 && age <= 122)
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                if (age >= 0)
                {
                    if (age <= 18)
                    {
                        Console.WriteLine("5$");
                    }
                    else if (age <= 64)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (age <= 122)
                    {
                        Console.WriteLine("10$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}