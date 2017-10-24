using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa saatujen klaavojen ja kruunien määrän:");
            Random rnd = new Random();
            string userinput = Console.ReadLine();
            int n = int.Parse(userinput);

            int kruunu = 0;
            int klaava = 0;

            for(int i = 1; i <= n; i++)
            {
                if (rnd.Next(2) == 1)
                {
                    kruunu = kruunu + 1;
                }
                else
                {
                    klaava = klaava + 1;
                }
            }
            Console.WriteLine($"Rahaa on heitetty {n} kertaa.");
            Console.WriteLine($"Kruunuja {kruunu} kertaa.");
            Console.WriteLine($"Klaavoja {klaava} kertaa.");
            Console.ReadKey();
        }
    }
}
