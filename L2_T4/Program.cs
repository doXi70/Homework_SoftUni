using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Month = Console.ReadLine();
            int NightsCount = int.Parse(Console.ReadLine());

            if (Month.Equals("May") || Month.Equals("October"))
            {
                if (NightsCount > 7)
                {
                    double PricePerNightStudio = 50;
                    double PricePerNightDouble = 65;
                    double PricePerNightSuite = 75;
                    if (Month.Equals("October"))
                    {
                        Console.WriteLine($"Studio: {((PricePerNightStudio * 0.95) * NightsCount) - PricePerNightStudio * 0.95:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {(PricePerNightStudio * 0.95) * NightsCount:F2} lv.");
                    }

                    Console.WriteLine($"Double: {PricePerNightDouble * NightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {PricePerNightSuite * NightsCount:F2} lv.");
                }
                else
                {
                    double PricePerNightStudio = 50;
                    double PricePerNightDouble = 65;
                    double PricePerNightSuite = 75;

                    Console.WriteLine($"Studio: {PricePerNightStudio * NightsCount:F2} lv.");
                    Console.WriteLine($"Double: {PricePerNightDouble * NightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {PricePerNightSuite * NightsCount:F2} lv.");
                }

            }
            else if (Month.Equals("June") || Month.Equals("September"))
            {
                if (NightsCount > 14)
                {
                    double PricePerNightStudio = 60;
                    double PricePerNightDouble = 72;
                    double PricePerNightSuite = 82;
                    if (Month.Equals("September"))
                    {
                        Console.WriteLine($"Studio: {(PricePerNightStudio * NightsCount) - PricePerNightStudio:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {PricePerNightStudio * NightsCount:F2} lv.");
                    }
                    Console.WriteLine($"Double: {PricePerNightDouble * 0.90 * NightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {PricePerNightSuite * NightsCount:F2} lv.");
                }
                else
                {
                    double PricePerNightStudio = 60;
                    double PricePerNightDouble = 72;
                    double PricePerNightSuite = 82;
                    if (Month.Equals("September") && NightsCount > 7)
                    {
                        Console.WriteLine($"Studio: {(PricePerNightStudio * NightsCount) - PricePerNightStudio:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {PricePerNightStudio * NightsCount:F2} lv.");
                    }
                    Console.WriteLine($"Double: {PricePerNightDouble * NightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {PricePerNightSuite * NightsCount:F2} lv.");
                }

            }
            else if (Month.Equals("July") || Month.Equals("August") || Month.Equals("December"))
            {
                if (NightsCount > 14)
                {
                    double PricePerNightStudio = 68;
                    double PricePerNightDouble = 77;
                    double PricePerNightSuite = 89;
                    Console.WriteLine($"Studio: {PricePerNightStudio * NightsCount:F2} lv.");
                    Console.WriteLine($"Double: {PricePerNightDouble * NightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {(PricePerNightSuite * 0.85) * NightsCount:F2} lv.");
                }
                else
                {
                    double PricePerNightStudio = 68;
                    double PricePerNightDouble = 77;
                    double PricePerNightSuite = 89;
                    Console.WriteLine($"Studio: {PricePerNightStudio * NightsCount:F2} lv.");
                    Console.WriteLine($"Double: {PricePerNightDouble * NightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {PricePerNightSuite * NightsCount:F2} lv.");
                }
            }
        }

    }
}
