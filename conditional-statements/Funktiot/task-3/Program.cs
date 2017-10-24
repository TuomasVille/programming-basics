using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Käyttäjältä pyydetään luku annetulta väliltä ja tarkastaa luvun kelpoisuuden.");
            Console.WriteLine("Funktio palauttaa käyttäjän syöttämän luvun.");

            int retNumber = numberFromRange(1, 10);
            Console.WriteLine($"Luku {retNumber} on sallittu");
            Console.ReadKey();

        }
        static int numberFromRange(int lowerBound, int upperBound)
        {
            int lower = 0;
            int upper = 0;
            bool isNumber;

            while (true)
            {
                Console.WriteLine("Anna luku väliltä 1-10:");
                isNumber = int.TryParse(Console.ReadLine(), out lower);
                if (lower >= lowerBound && lower <= upperBound)
                {
                    upper = lower;
                    break;
                }
                else
                {
                    isNumber = false;
                }           
            }
            while (isNumber == false) ;
            return lower;

        }
    }
        
    
}

