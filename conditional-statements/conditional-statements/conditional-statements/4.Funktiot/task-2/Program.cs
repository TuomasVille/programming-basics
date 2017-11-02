using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Palauttaa arvonaan kahdesta annetusta luvusta pienemmän.Luvut välitetään funktiolle parametrina.");
            Console.WriteLine("Anna ensimmäinen luku: ");
            string userinput = Console.ReadLine();
            int x = int.Parse(userinput);
            Console.WriteLine("Anna toinen luku: ");
            string userinput2 = Console.ReadLine();
            int y = int.Parse(userinput2);

            int p = laskin(x, y);
            if (x == p && x != y)
            {
                Console.Write($"Luku {x} on pienempi kuin luku {y}");
            }
            else if(y == p && y !=x)
            {
                Console.WriteLine($"Luku {y} on pienempi kuin luku {x}");
            }
            else
            {
                Console.WriteLine($"Luvut {x} ja {y} ovat yhtäsuuria");
            }
            Console.ReadKey();


        }
        static int laskin(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }   
    }
}
