﻿using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
    Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Define instructions
            Console.WriteLine("Ohjelma selvittää onko syötetty luku parillinen vai pariton, positiivinen vai negatiivinen.");
            bool isNumber;
            do
            {

                Console.Write("Syötä luku: ");
                // define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                // programming logics
                if (evaluatedNumber % 2 == 0)
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on parillinen");
                }
                else if (evaluatedNumber % 2 == 1)
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on pariton");
                }
                else
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on pariton");
                }
                if (evaluatedNumber < 0)
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
                }
                else if (evaluatedNumber >= 0)
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
                }
               
                
            } while (isNumber == true);
            Console.ReadKey();
        }
    }
}
            

            








