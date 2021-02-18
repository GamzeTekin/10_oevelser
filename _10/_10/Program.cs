using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Self-Checkout");
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            //Beder om input, som er af typen string og parser den derefter til en double 
            Console.WriteLine("Price of item1: ");
            string input1 = Console.ReadLine();

            double a = double.Parse(input1);
            
            Console.WriteLine("quantity of item1: ");
            string input2 = Console.ReadLine();

            int b = Int32.Parse(input2);

            Console.WriteLine("Price of item2: ");
            string input3 = Console.ReadLine();

            double c = double.Parse(input3);

            Console.WriteLine("quantity of item2: ");
            string input4 = Console.ReadLine();

            int d = Int32.Parse(input4);

            Console.WriteLine("Price of item3: ");
            string input5 = Console.ReadLine();

            double e = double.Parse(input5);

            Console.WriteLine("quantity of item3: ");
            string input6 = Console.ReadLine();

            int f = Int32.Parse(input6);

            //double total er udregner subtotalen
            //double y er procenten, som jeg bruger til at udregne Tax
            //double result er udregningen af Tax
            //double end er udregningen af subtotal og tax sammenlagt
            double total = a + c + e;
            double y = 5.50;
            double result = (total / 100) * y;
            double end = total + result;

            //Her runder jeg op, så jeg kun får to decimaler 
            result = Math.Round(result, 2);
            end = Math.Round(end, 2);





            Console.WriteLine("\nSubtotal: " + "$"+total );
            Console.WriteLine("Tax: " + "$"+result);
            Console.WriteLine("Total: " + "$" + end);
           




        }
    }
}
