using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_T15
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDMG = int.Parse(Console.ReadLine());
            int GoshoDMG = int.Parse(Console.ReadLine());
            int PeshoHP = 100, GoshoHP = 100;


            for (int i = 1; true; i++)
            {
                if (i % 2 == 0)
                {
                    PeshoHP -= GoshoDMG;

                    if (PeshoHP <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist" +
                                      $" and reduced Pesho to {PeshoHP} health.");
                    }
                }
                else
                {
                    GoshoHP -= PeshoDMG;
                    if (GoshoHP <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick" +
                                      $" and reduced Gosho to {GoshoHP} health.");
                    }
                }

                if (i % 3 == 0)
                {
                    PeshoHP += 10;
                    GoshoHP += 10;
                }
            }
        }
    }
}
