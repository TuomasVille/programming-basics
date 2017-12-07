using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy käyttäjältä sanan tai lauseen ja tulostaa sen niin monta kertaa näytölle kuin sanassa on kirjaimia:");
            Console.Write("Sýötä sana tai lause: ");
            string userInput;
            userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.Write($"{i}. ");
                Console.WriteLine(userInput);      
            }
            Console.ReadKey();
        }
    }
}
