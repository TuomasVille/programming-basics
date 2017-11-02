using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Laskee N:n ensimmäisen parittoman ja parillisen lukujen summan!");
            int luku = 1;
            {
                Console.Write("Syötä luku: ");

                luku = int.Parse(Console.ReadLine());
                if (luku < 0)
                {
                    Console.WriteLine("Määrittelemätön");
                    
                }
                int i = 1;
                int parillinen = 0;
                int pariton = 0;
                while (i <= luku)
                {
                    if (i % 2 != 0)
                    {
                        pariton = pariton + i;    
                    }
                    else
                    {
                        parillinen = parillinen + i;   
                    }
                    i++;
                }
                Console.WriteLine("Parittomien summa = " + pariton);
                Console.WriteLine("Parillisten summa = " + parillinen);
                Console.ReadKey();
            }
        }
    }
}


