using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma simuloi nopanheittoa 1000 kertaa ja tulostaa lisäksi kuutosen esiintymiskertojen lukumäärän:");
            Random rnd = new Random();
            int n = 0;

            for(int i = 0; i < 1000; i++ )
            {
                int k =rnd.Next(1,7);  
                if(k == 6)
                {
                    n = n + 1;
                }
            }
            Console.WriteLine($"Heitit noppaa 1000 kertaa.");
            Console.WriteLine($"Kuutonen arvottiin {n} kertaa.");

            Console.ReadKey();
            


        }
    }
}
