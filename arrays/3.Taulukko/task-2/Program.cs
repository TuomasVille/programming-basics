using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo kaksiulotteiseen taulukkoon arvot 0-100:");
            int[,] arrays = new int[10,20];
            Random rnd = new Random();
            Console.WriteLine("[X, Y] = Arvo");

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (arrays[x, y] < 10)
                    {
                        arrays[x, y] = int.Parse(getNum((rnd.Next(0, 100))));
                        Console.WriteLine($"[{x}, {y}] = {arrays[x, y]:00}");
                    }
                }
            }
            Console.ReadKey();
        }
        static string getNum(int Number)
        {
            string num = "";

            if (Number < 10)
            {
                num = Number.ToString();
            }
            else
            {
                num = Number.ToString();
            }
            return num;
        }
    }
}

