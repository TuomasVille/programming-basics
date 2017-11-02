using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            float discount = 0.0f;
            int price = 16;

            Console.WriteLine("Maatalousnäyttelyn lipun hinta:");

            Console.WriteLine();

            //Information
            Console.Write("Ikä: ");
            int age = int.Parse(Console.ReadLine());

            //Program logics
            if (age < 7)
            {
                Console.WriteLine("Hinta = " + price * 0 + "€");
            }
            else if(age >= 7 && age <= 15)
            {
                Console.WriteLine("Hinta = " + price * 0.5 + "€");
            }
            else if (age >= 65)
            {
                Console.WriteLine("Hinta = " + price * 0.5 + "€");
            }
            if (age > 15 && age < 65)
            {
                Console.Write("Varusmies? [Y/N]: ");
                if (Console.ReadLine().ToUpper() == "Y")
                    Console.WriteLine("Hinta = " + price * 0.5 + "€");

                else
                {
                    Console.Write("Mtk jäsen? [Y/N]: ");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        discount = 0.15f;
                    }
                    Console.Write("Opiskelija? [Y/N]: ");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        discount = discount + 0.45f;
                    }
                    Console.WriteLine($"Hinta = {price - price * discount}€");
                }
            }
            Console.ReadKey();
        }
    }
}
