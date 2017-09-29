using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_T14
{
    class Program
    {
        static void Main(string[] args)
        {
            char FirstLetter = char.Parse(Console.ReadLine());
            char SecondLetter = char.Parse(Console.ReadLine());
            char ForbiddenLetter = char.Parse(Console.ReadLine());

            for (char i = FirstLetter; i <= SecondLetter; i++)
            {
                for (char j = FirstLetter; j <= SecondLetter; j++)
                {
                    for (char k = FirstLetter; k <= SecondLetter; k++)
                    {
                        if (k.Equals(ForbiddenLetter) || j.Equals(ForbiddenLetter) || i.Equals(ForbiddenLetter))
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{i}{j}{k}");
                            if (i.Equals(SecondLetter) && j.Equals(SecondLetter) && k.Equals(SecondLetter))
                            {

                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
