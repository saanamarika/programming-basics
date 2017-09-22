using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // define instructions
            Console.WriteLine("Ohjelma selvittaa onko syotetty luku pariton vai parillinen.");
            bool isNumber;
            Console.Write("Syota luku: ");
                // define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                // program logic
                if(evaluatedNumber % 2 == 0)
            {
                Console.WriteLine($"Syotit luvun {evaluatedNumber}, se on parillinen");
            }
                else
            {
                Console.WriteLine($"Syotit luvun {evaluatedNumber}, se on pariton");
            }


            Console.ReadKey();
        }
    }
}
