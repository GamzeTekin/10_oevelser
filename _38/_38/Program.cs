using System;

namespace _38
{
    class Program
    {


        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a list of 10 numbers seperated by spaces: ");
            //string input = Console.ReadLine();


            int i = 0;
            //declare array of integers
            int[] arr = new int[10];

            //reading elements
            Console.WriteLine("Enter 10 numbers: ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                  
            }

            
            filterEvenNumbers(arr, i);



        }

        public static void filterEvenNumbers(int[] arr, int i)
        {
            //checking and printing list of EVEN integers
            Console.WriteLine("List of even numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                //condition for EVEN number
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + ",");

            }
            
           
        }


    }

}
