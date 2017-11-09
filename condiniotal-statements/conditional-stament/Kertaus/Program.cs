using System;

namespace Kertaus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Syötä sana tai lause: ");
            string useri = Console.ReadLine();

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"{i}. {useri}");
            }
            Console.ReadKey();
        }
    }
}
