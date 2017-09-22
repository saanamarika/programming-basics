using System;

namespace Task_3
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
                        if (evaluatedNumber % 2 == 0)
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen ja parillinen");
                        }
                        else
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen ja pariton");
                        }
                    }
                    else if (evaluatedNumber > 0)
                    {
                        if (evaluatedNumber % 2 == 0)
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on posiitivinen ja parillinen");
                        }
                        else
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on positiivinen ja pariton");
                        }
                    }
                    else
                    {
                        if (evaluatedNumber % 2 == 0)
                            Console.WriteLine($"Numero {evaluatedNumber} on nolla ja parillinen");
                    }
                }
                else
                {
                    Console.WriteLine("Syötit muuta kuin numeroita!");
                }
            } while (isNumber == false) ;
                Console.ReadKey();

            
        }
    }
}

