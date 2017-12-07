using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy käyttäjältä lukuja, kunnes hän syöttää kaksi samaa lukua peräkkäin!");
            bool isNumber;
            do
            {

                Console.WriteLine("Syötä luku:");
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                if (isNumber == true)
                {

                }

            }
            while (isNumber == true);
            Console.ReadKey();
        }
    }
}

