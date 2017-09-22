using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define instructions
            Console.WriteLine("Ohjelma selvittää onko syötetty luku parillinen vai pariton.");
            bool isNumber;
            do
            {

                Console.Write("Syötä luku: ");
                // define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                // programming logics
                if (evaluatedNumber % 2 == 0)
                {
                    Console.WriteLine($"Syötit luvun{evaluatedNumber}, se on parillinen");
                }
                else if (evaluatedNumber > 0)
                {
                    Console.WriteLine($"Syötit luvun{evaluatedNumber}, se on pariton");
                }

                else
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on nolla");
                }
            } while (isNumber == true);
            Console.ReadKey();
        }
    }
}
            

            














