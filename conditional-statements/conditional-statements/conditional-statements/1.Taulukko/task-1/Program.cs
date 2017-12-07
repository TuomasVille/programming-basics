using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] iT = new int[100];
            int i;
            double sum = 0;

            for(i = 0; i < 100; i++)
            {
                iT[i] = rnd.Next(50);
            }
            for(i = 0; i < 100; i++)
            {
                sum = sum + iT[i];
            }
            Console.WriteLine($"Lukujen keskiarvo = {sum / 100} ");
            Console.WriteLine($"Lukujen summa = {sum}");
            Console.ReadKey();
        }
    }
}
