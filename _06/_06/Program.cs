using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Retirement calculator");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();

            //beder om input, som er af typen string der skal parses til typen int 
            Console.WriteLine("What is your current age?");
            string input1 = Console.ReadLine();

            int a = Int32.Parse(input1);

            Console.WriteLine("At what age would you like to retire?");
            string input2 = Console.ReadLine();

            int b = Int32.Parse(input2);

            int result1 = b - a;
            Console.WriteLine("You have " + result1 + " years left to retire");

            //det nuværende år
            DateTime now = DateTime.Today;

           //året du kan gå på pension
             long n = long.Parse(DateTime.Today.ToString("yyyy"));

            var result2 = n += result1;

            


            Console.WriteLine("You can retire in {0} ", result2);
        }
    }
}
