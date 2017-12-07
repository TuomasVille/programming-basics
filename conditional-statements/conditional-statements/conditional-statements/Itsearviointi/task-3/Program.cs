using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy käyttäjältä lukuja, kunnes hän syöttää luvun -1. Ohjelma tulostaa näytölle syötettyjen lukujen summan.");
            int n = 0;
            int summa = 0;
            do
            {
                Console.WriteLine("Syötä luku:");
                n = int.Parse(Console.ReadLine());
                summa = summa + n;
            }
            while (n != -1);
            Console.WriteLine($"Lukujen summa on {summa + 1} ");
            Console.ReadKey();
        }
    }
}
