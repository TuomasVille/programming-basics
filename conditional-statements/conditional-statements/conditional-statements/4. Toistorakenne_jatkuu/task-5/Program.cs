using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin (13 kohdetta)");
            Console.WriteLine("1 = Kotivoitto, X = Tasapeli ja 2 = Vierasvoitto");
            Random rnd = new Random();

            for (int i = 1; i < 14; i++)
            {
                Console.Write($"{i}. ");
                Double k = rnd.NextDouble();

                if (k < 0.4)
                {
                    Console.WriteLine("1");
                }
                else if (k > 0.4 && k < 0.6)
                {
                    Console.WriteLine("X");
                }
                else
                    Console.WriteLine("2");
            }
            Console.ReadKey();
        }  
    }
}
