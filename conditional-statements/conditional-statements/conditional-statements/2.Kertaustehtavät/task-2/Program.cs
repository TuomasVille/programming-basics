using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Minäpä tiedän luvun väliltä 1-100, jota sinä et tiedä!");
            Random rnd = new Random(100);

            do
            {
                Console.WriteLine("Arvaa luku: ");
                string userInput;
                userInput = Console.ReadLine();
                int luku = int.Parse(userInput);

                for (int i = 0; i < 1;)
                {

                    if (rnd.Next(100) < luku)
                    {
                        Console.WriteLine("Lukuni on pienempi!");
                    }
                    else if (rnd.Next(100) > luku)
                    {
                        Console.WriteLine("Lukuni on suurempi!");
                    }
                    else if (luku >= 100)
                    {
                        Console.WriteLine("Ei kelvollinen luku!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Oikein! Arvauksia yhteensä: ");
                    }
                    break;
                }
            }
            while (true);
        }
    }
}
