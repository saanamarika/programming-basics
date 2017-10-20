using System;

namespace Task_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma simuloin nopan heittoa 1000 kertaa ja tulostaa lisäksi kuutosten esiintymiskertojen lukumäärän");
            Random rand = new Random();
            int total;

            for (int i=1; i<=1000; i++)
            {
                Console.WriteLine($"{i}. {rand.Next(1,7)}");
            }
            Console.ReadKey();
        }
    }
}
