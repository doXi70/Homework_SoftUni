using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int currEn = int.Parse(Console.ReadLine());
            int maxEn = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            Console.WriteLine("Health: |{0}{1}|",
                ToRepeat("|", currHP),
                ToRepeat(".", maxHP - currHP));

            Console.WriteLine("Energy: |{0}{1}|",
                ToRepeat("|", currEn),
                ToRepeat(".", maxEn - currEn));
        }

        static string ToRepeat(string text, int count)
        {
            string st = "";

            for (int i = 0; i < count; i++)
            {
                st += text;
            }

            return st;
        }

    }
}
