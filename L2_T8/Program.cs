using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_T8
{
    class Program
    {
        const int Cheese = 500, TomatoSauce = 150, Salami = 600, Pepper = 50;

        static void Main(string[] args)
        {

            int calories = 0;

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string Ingredient = Console.ReadLine().ToLower();

                switch (Ingredient)
                {
                    case "cheese":
                        calories += Cheese;
                        break;
                    case "tomato sauce":
                        calories += TomatoSauce;
                        break;
                    case "salami":
                        calories += Salami;
                        break;
                    case "pepper":
                        calories += Pepper;
                        break;
                }

            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
