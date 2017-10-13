using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kirjoittaa kertotaulun luvuille 1-9");
            for (int i = 1; i <= 9; i++)
            {
                for (int j=1; j<=9; j++)
                {
                    Console.WriteLine($"{i}x{j}={i*j}");
                }
            }

            Console.ReadKey();
        }
    }
}
