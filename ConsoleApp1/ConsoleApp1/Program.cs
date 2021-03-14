using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>(); // création de la liste

            Console.WriteLine("Veuillez entrer une phrase: ");
            string word = Console.ReadLine();
            for (int i = 1; i < word.Length; i++)
                {
                Console.WriteLine(word.Substring(i, i));
                }
        }
    }
}
