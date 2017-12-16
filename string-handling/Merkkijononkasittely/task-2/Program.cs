using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma muuttaa käyttäjän syöttämästä syötteestä e kirjaimet @ merkiksi:");
            Console.WriteLine("Kirjoita jotain:");

            while (true)
            {
                string userInput = Console.ReadLine();
                Console.WriteLine(userInput.Replace("e", "@"));
                Console.ReadKey();              
            }
        }
    }
}
