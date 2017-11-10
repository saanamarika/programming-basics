using System;

namespace Kertaus_if1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma pyytää syöttämään luvun, jonka jälkeen se kertoo onko luku: negatiivinen, positiivinen tai nolla");
            bool isNumber;
            do
            {
                Console.Write("Syötä luku: ");
                string num = Console.ReadLine();
                double numero;
                isNumber = double.TryParse(num, out numero);
                if (isNumber == false)
                {
                    Console.WriteLine("Syötit muuta kuin numeroita! Hölömö");
                }
                else
                {
                    if (numero < 0)
                    {
                        Console.WriteLine($"{numero} on negatiivinen");
                    }
                    else if (numero > 0)
                    {
                        Console.WriteLine($"{numero} on positiivinen");
                    }
                    else
                    {
                        Console.WriteLine($"{numero} on nolla");
                    }
                }
            }
            while (isNumber == false);
            Console.ReadKey();
        }
    }
}
