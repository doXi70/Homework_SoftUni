using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                string text = noun.Remove(noun.Length - 1, 1);
                text += "ies";
                Console.WriteLine(text);
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") ||
                    noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                noun += "es";
                Console.WriteLine(noun);
            }
            else
            {
                noun += "s";
                Console.WriteLine(noun);
            }

        }
    }
}