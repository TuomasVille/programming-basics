using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä [0-50]");
            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Rivi{i + 1}: ");
                for (int j = 0; j < 5; j++)
                {
                    if( j < 4)
                    {
                        Console.Write($"{rnd.Next(50)}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{rnd.Next(50)}");
                    }     
                }     
            }
            Console.ReadKey();
        }     
    }
}
