using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("tulostaa N! kertoman arvon!");
            int luku = -1;
            while (luku != 100)
            {
                Console.Write("Syötä luku:");

                luku = int.Parse(Console.ReadLine());
                if (luku < 0)
                {
                    Console.WriteLine("Määrittelemätön");
                    continue;
                }
                double kertoma = 1;
                int i = 1;
                while (i <= luku)
                {
                    kertoma = kertoma * i;
                    i++;
                }
                if (luku >= 0)
                {
                    Console.WriteLine("Luvun " + luku + " kertoma on " + kertoma);
                }



            }
        }
    }
}



