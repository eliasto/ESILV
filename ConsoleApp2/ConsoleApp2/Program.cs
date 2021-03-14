using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] tableau = { 3, 1, 5, 3, 1, 1, 2, 5, 8 };

            int b = 0;

            for (int i = 0; i < 5; i = i + 1)

            {

                b = b + tableau[i];

            }

            Console.WriteLine(“b =”+b);


        }
