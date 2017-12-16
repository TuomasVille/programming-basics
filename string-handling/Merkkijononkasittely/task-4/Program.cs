using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tarkastaa onko käyttäjältä kysytty sana tai lause palintromi.");
            Console.WriteLine();
            Console.WriteLine("Syötä palintromi: ");
            string UserInput = Console.ReadLine();
            string reverseUserInput = "";

            for(int i = UserInput.Length-1; i >= 0; i--)
            {
                reverseUserInput += UserInput[i];
            }
            if(UserInput == reverseUserInput)
            {
                Console.WriteLine();
                Console.WriteLine($"Sana {UserInput.ToUpper()} on palintromi");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Sana {UserInput.ToUpper()} ei ole palintromi");
            }
            Console.ReadKey();
        }
    }
}
