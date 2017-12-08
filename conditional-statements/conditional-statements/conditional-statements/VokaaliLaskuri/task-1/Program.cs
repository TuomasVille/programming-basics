using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Laskee vokaalien määrän syötteestä");
            Console.Write("Kirjoita jotain: ");
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            string Input = Console.ReadLine().ToLower();

            char[] carray = Input.ToCharArray();

            for(int i = 0; i < Input.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (carray[i] == vowels[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Sanassa {Input} on {count} vokaaalia.");
            Console.ReadKey();
        }
    }
}
