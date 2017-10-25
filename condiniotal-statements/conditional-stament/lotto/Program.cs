using System;

namespace lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma antaa loton oikean rivin, lisänumeron ja tuplausnumeron");
            int[] lotto = new int[40];
            Random rnd = new Random();
            int rndIndex = 0;
            for (int i = 0; i < 7; i++)
            {
                rndIndex = rnd.Next(40);
                if (lotto[rndIndex] == 0)
                {
                    lotto[rndIndex] = 1;
                }
                else
                {
                    i--;
                }
            }
            //määritä uusi index, jotta tiedetään se 1:n lukumäärä mitä voidaan käyttää sitten vertailussa
            int orderIndex = 0;
            for (int i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == 1)
                {
                    if (orderIndex < 6)
                    {
                        Console.Write($"{i + 1},");
                        orderIndex++;
                        //tässä käytettiin se orderIndex
                    }
                    else
                    {
                        Console.Write($"{i + 1}");
                    }
                }
            }
            //ikisilmukka
            while (true)
            {
                rndIndex = rnd.Next(40);
                if (lotto[rndIndex] == 0)
                {
                    lotto[rndIndex] = 2;
                    Console.WriteLine($"\nLisänumero: {rndIndex + 1}");
                    //mikä päätetään breikkiin
                    break;
                }

            }
            //pelkän yhden luvun arvonta
            Console.WriteLine($"Tuplausnumero: {rnd.Next(40)}");

            Console.ReadKey();
        }
    }
}


