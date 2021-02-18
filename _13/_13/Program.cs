using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Determining compound interest");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            //Deklarere og sætter min double først og derefter beder jeg om input, som skal parses til double da det er en string format
            double l = 0;
            Console.WriteLine("What is the principal amount? : ");
            string input1 = Console.ReadLine();

            double a = double.Parse(input1);

            Console.WriteLine("What is the rate? : ");
            string input2 = Console.ReadLine();

            double b = double.Parse(input2);

            Console.WriteLine("What is the number of years? : ");
            string input3 = Console.ReadLine();

            double c = double.Parse(input3);

            Console.WriteLine("What is the number of times the interest is compounded per year? : ");
            string input4 = Console.ReadLine();

            double d = double.Parse(input4);

            //deklarere og sætter mine var og bruger dem til den matematiake formel forneden til det samlede resultet
            var p = a;
            var r = b;
            var n = d;
            var t = c;
            l = p * Math.Pow(1 + (r / n), (n * t));
            l = Math.Round(l, 2);

            Console.WriteLine("$" + input1 + " invested at " + input2 + "% for " + input3 + " years, compounded " + input4 + " per year is " + l);
           

          








        }
    }
}
