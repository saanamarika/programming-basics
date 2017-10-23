using System;

namespace Funktio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma pyytää sinua syöttämään 10 positiivista kokonaislukua, sen jälkeen se kertoo sinulle mitä syötit ja mikä niistä oli suurin");



        }
        static int Numbers(int userInput)
        {
            Console.WriteLine("Syötä 10 positiivista kokonaislukua");
            for (int i = 0; i <= 10; i++)
            {
                bool num = false;
                do
                {
                    Console.Write($"{i}. ");
                    num = int.TryParse(Console.ReadLine(), out int numero);
                    if (!num)
                    {
                        Console.WriteLine("Väärä syöte, syötä positiivinen lukua!");
                    }
                }
                while (!num);
            }
        }
    }
}
