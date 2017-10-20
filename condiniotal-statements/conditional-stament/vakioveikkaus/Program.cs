using System;

namespace vakioveikkaus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen oikean rivin");
            Random rand = new Random();
            double randNumber = 0.0;

            for (int i = 1; i <= 13; i++)
            {
                randNumber = rand.NextDouble();
                if (randNumber < 0.4)
                {
                    Console.WriteLine($"{i}. 1");
                }
                else if (randNumber > 0.4 && randNumber < 0.6)
                {
                    Console.WriteLine($"{i}. X");
                }
                else
                {
                    Console.WriteLine($"{i}. 2");
                }

            }
            Console.ReadKey();
        }
    }
}
