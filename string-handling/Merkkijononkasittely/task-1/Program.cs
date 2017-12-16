using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma ilmoittaa syötteestä merkkien lukumäärän:");
            Console.WriteLine("Kirjoita jotain:");
            
            while(true)
            {
                string userInput = Console.ReadLine();
                Console.WriteLine($"Syötteessä on {userInput.Length} merkkiä.");
            }
            Console.ReadKey();
        }
    }
}
