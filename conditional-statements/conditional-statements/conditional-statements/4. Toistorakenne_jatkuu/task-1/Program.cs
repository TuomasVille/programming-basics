using System;

namespace _4._Toistorakenne_jatkuu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret:");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i}\t\t{Math.Round(Math.Sqrt(i),2)}");
            }
            Console.ReadKey();
        }    
    }
}
