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
                    Print("Suitable for Vegetarians", ConsoleColor.Green);
                    break;
                case "meat feast":
                case "pepperoni":
                    Print("NOT Suitable for vegetarians", ConsoleColor.Red);
                    break;
                default:
                    Print("UNKOWN PIZZA! MAY CONTAIN MEAT!");
                    break;
            }

            Console.ReadLine();
        }
        /// <summary>
        /// Outputs text to console
        /// </summary>
        /// <param name="text">output text</param>
        /// <param name="colour">text colour</param>
        private static void Print(string text, ConsoleColor colour = ConsoleColor.White, bool NewLine = true)
        {
            Console.ForegroundColor = (colour);

            if (NewLine)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.Write(text);
            }
            Console.ResetColor();
        }
            

        /// <summary>
        /// get input from console
        /// </summary>
        /// <param name="question">the question to ask</param>
        /// <returns>input from console</returns>
        private static string Input(string question)
        {
            Console.Write(question);
            string answer = Console.ReadLine();

            return answer;
        }

        
    }
}
