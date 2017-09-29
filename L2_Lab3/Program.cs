using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins += 30;

            if (mins > 59)
            {
                hours++;

                if (hours >= 23)
                {
                    hours = 0;
                }

                mins -= 60;
            }



            Console.WriteLine($"{hours}:{mins:D2}");
        }
    }
}
