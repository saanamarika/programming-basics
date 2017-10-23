using System;

namespace Funktio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tarkistaa antamasi luvun onko se 1-10 väliltä, pyytää syöttämään uudelleen jos olet hölmö");
            int retNumber = numberFromRange(1, 10);
            Console.WriteLine($"Syötit kelvollisen luvun.");
            Console.ReadKey();
           
        }
        static int numberFromRange(int lowerBound, int upperBound)
        {
            int number = 0;
            bool numb = false;
            do
            {
                Console.Write($"Syötä luku {lowerBound}-{upperBound} väliltä: ");
                numb = int.TryParse(Console.ReadLine(), out number);
                if(!numb||number<lowerBound||number>upperBound)
                {
                    Console.WriteLine("Olet hölmö. ");
                }

            }
            while (number < lowerBound || number > upperBound||!numb);
            return number;
        }
        
    }
}
