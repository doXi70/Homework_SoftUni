using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_T9
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                try
                {
                    int IsItNumber = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
