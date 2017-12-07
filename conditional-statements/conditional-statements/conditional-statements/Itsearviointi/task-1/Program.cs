using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy käyttäjältä sanan tai lauseen ja tulostaa sen 5 kertaa näytölle:");
            Console.Write("Sýötä sana tai lause: ");
            string userInput;
            userInput = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i}. ");
                Console.WriteLine(userInput);
            }
            Console.ReadKey();
        }
    }
}
