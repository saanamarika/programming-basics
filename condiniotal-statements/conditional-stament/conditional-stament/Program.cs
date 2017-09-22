using System;

namespace conditional_stament
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // define instructions
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla");
            bool isNumber;
            do
            {
                Console.Write("Syötä luku: ");
                // define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                // program logic
                if (isNumber == true)
                {
                    if (evaluatedNumber < 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
                    }
                    else if (evaluatedNumber > 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on posiitivinen");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on nolla");
                    }
                }
                else
                {
                    Console.WriteLine("Syötit muuta kuin numeroita!");
                }
            } while (isNumber == false);
            Console.ReadKey();

        }
    }
}
