using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            string pizza = "";

            Console.Write("What type of pizza do you like? : ");
            pizza = Console.ReadLine().ToLower();

            switch (pizza)
            {
                case "cheese and tomato":
                case "margherita":
                    Console.WriteLine("Suitable for Vegetarians");
                    break;
                case "meat feast":
                case "pepperoni":
                    Console.WriteLine("NOT Suitable for vegetarians");
                    break;
                default:
                    Console.WriteLine("UNKOWN PIZZA! MAY CONTAIN MEAT!");
                    break;
            }
        }
    }
}
