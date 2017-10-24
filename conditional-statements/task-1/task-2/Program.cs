using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9:");

            for (int x = 1; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    Console.WriteLine($"{x} x {y} = {x * y}");
                }
                
            }
            Console.ReadKey();
        }
    }
}
