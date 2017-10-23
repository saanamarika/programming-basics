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
            int x = 0;
            int kuusi = 0;
            for (int i=1; i<=1000; i++)
            {
                x = rand.Next(1, 7);
                Console.WriteLine($"{i}. {x}");
                if (x == 6)
                {
                    kuusi++;
                }
            }
            Console.WriteLine($"Kuutonen arvottiin {kuusi} kertaa.");
            Console.ReadKey();
        }
    }
}
