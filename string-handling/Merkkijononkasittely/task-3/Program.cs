using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Laskee syötteeestä L kirjainten lukumäärän:");
            Console.WriteLine("Kirjoita jotain: ");
            int count = 0;
            var word = new[] { 'l' };

            string userInput = Console.ReadLine().ToLower();

            char[] carray = userInput.ToCharArray();

            for (int i = 0; i < userInput.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if(carray[i] == word[j])
                    count++;
                }
            }
            Console.WriteLine($"Syötteessä {userInput} on {count} L kirjainta.");
            Console.ReadKey();
        }
    }
}
