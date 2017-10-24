using System;

namespace Funktio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma pyytää sinua syöttämään 10 positiivista kokonaislukua, sen jälkeen se kertoo sinulle mitä syötit ja mikä niistä oli suurin");
            //silloin voi tulostaa funktion ilman arvoa
            Console.WriteLine(Numbers());
            Console.ReadKey();

        }
        //ei välttämättä tarvitse arvoa
        static string Numbers()
        {
            Console.WriteLine("Syötä 10 positiivista kokonaislukua");
            int numero = 0;
            int big = 0;
            int indexOfBig = 0;
            string numberLine ="";
            for (int i = 1; i <= 10; i++)
            {
                bool num = false;
                do
                {
                    Console.Write($"{i}. ");
                    num = int.TryParse(Console.ReadLine(), out numero);
                    if (!num||numero<=0)
                    {
                        Console.WriteLine("Väärä syöte, syötä positiivinen luku!");
                    }
                    if (big<numero)
                    {
                        //muista aina määrittää tekijä
                        big = numero;
                        indexOfBig = i;
                    }
                }
                while (!num||numero<=0);
                numberLine += ($"{numero} ");
            }
            Console.WriteLine($"Syötit seuraavat luvut:\n{numberLine}");
            return ($"Suurin {big} oli {indexOfBig}. luku");
        }
    }
}
