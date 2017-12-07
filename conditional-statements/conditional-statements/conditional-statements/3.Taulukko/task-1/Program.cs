using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo yksiulotteiseen taulukkoon arvot 0-20:");
            string[] array = new string[10];
            Random rnd = new Random();
            Console.WriteLine("[X] = Arvo");

            for (int i = 0; i < 10; i++)
            {
                array[i] = getNum(rnd.Next(0,20));
                Console.WriteLine($"[{i + 1}] = {array[i]}");
            }
            Console.ReadKey();
        }
        static string getNum(int Number)
        {
            string num = "";

            if (Number < 10)
            {
                num = "0" + Number.ToString();
            }
            else
            {
                num = Number.ToString();
            }
            return num;
        }             
    }
}
