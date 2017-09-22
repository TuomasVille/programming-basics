﻿using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Define instructions
            Console.WriteLine("Lajittele luvut nousevaan järjestykseen.");
            bool isNumber;
            do
            {

                Console.Write("Syötä luku X ,");
                Console.Write("Syötä luku Y ,");
                Console.Write("Syötä luku Z.");
                // define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                // programming logics
                if (isNumber == true)
                {
                    if (evaluatedNumber < 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
                    }
                    else if (evaluatedNumber > 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on nolla");
                    }
                }
                else
                {
                    Console.WriteLine("Syötit muuta kuin numeron");
                }

            } while (isNumber == true);
            Console.ReadKey();

        }
    }
}
