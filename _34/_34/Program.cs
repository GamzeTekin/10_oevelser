using System;
using System.Collections.Generic;
using System.Linq;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array string 
            string[] E = { "Niels", "Anna", "Karl", "Nethe", "Lars", "Gitte", "Nynne", "Ronni" };

            //Foreach til at udskrive 
            foreach (string c in E)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("\nEnter a employee name you would like to remove from the list: ");

            string input = Console.ReadLine();
            Console.WriteLine();

            //You use a lambda expression to create an anonymous function(int this case "i"). Use the lambda declaration operator => to separate the lambda's parameter list from its body
            E = Array.FindAll(E, i => i != input).ToArray();
            Console.WriteLine(String.Join("\n", E));

           


        }
    }
}
