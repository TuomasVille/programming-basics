using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma pyytää käyttäjältä 10 positiivista kokonaislukua ja palauttaa niistä suurimman:");
            Console.WriteLine("Syötteeksi kelpaa vain positiiviset luvut");
            Console.WriteLine("Virheellisestä luvusta tulostetaan ilmoitus ja luku pyydetään uudestaan.");
            Console.WriteLine();

            Console.WriteLine($"Suurin luku oli " + number());
            Console.ReadKey();
        }
        static int number()
        {
            bool isNumber;
            int max = 0;
            int num = 0;
            string result = "";

            Console.WriteLine("Syötä 10 lukua:");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. ");

                if (isNumber = int.TryParse(Console.ReadLine(), out num) && num > -1)
                {
                    if (max < num)
                    {
                        max = num;
                    }
                    result += $"{num} ";
                }
                else
                {
                    Console.WriteLine("Väärä syöte, syötä positiivinen luku");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Syötit seuraavat luvut: {result}");
            Console.WriteLine();
            return max;
        }
    }
}
         