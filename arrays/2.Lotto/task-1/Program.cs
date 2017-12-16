using System;
using System.Linq;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo 7 eri lukua 1-40 ja tulostaa arvotut luvut pienimmästä suurimpaan.");
            Console.WriteLine("Loton oikea rivi on: ");
            Random rnd = new Random();
            int[] iT = new int[7];
            int extraNumber;

            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(1,41);

                for (int j = 1; j < i; j++)
                {
                    if (iT[j] == iT[i])
                    {
                        i--;
                    }
                }
            }
            Array.Sort(iT);
            while(true)
            {
                extraNumber = rnd.Next(1, 41);
                if (!iT.Contains(extraNumber))
                {
                    break;
                }             
            }


            for (int i = 0; i < iT.Length; i++)
            {
                Console.Write($"{iT[i]},");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Lisänumero: {extraNumber}");
            Console.WriteLine($"Tuplausnumero: {rnd.Next(1,41)}");
            Console.ReadKey();
        }
    }
}
