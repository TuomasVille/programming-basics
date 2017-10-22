using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Laskee N ensimmäistä lukua yhteen!");
            int luku = 0;
            {
                Console.Write("Syötä luku:");

                luku = int.Parse(Console.ReadLine());
                if (luku < 0)
                {
                    Console.WriteLine("Määrittelemätön");
                }
                int summa = 0;
                int i = 1;
                while (i <= luku)
                {
                    summa = summa + i;
                    i++;
                }
                if (luku >= 0)
                {
                    Console.WriteLine("Luvun " + luku + " summa on " + summa);
                }
                Console.ReadKey();

            }
        }
    }
}



