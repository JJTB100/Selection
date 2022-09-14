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
            string pizza = Input("What Pizza?").ToLower();

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

        private static string Input(string question)
        {
            Console.Write(question);
            string answer = Console.ReadLine();

            return answer;
        }
    }
}
