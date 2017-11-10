using System;

namespace Kertaustaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] number = new int[5];
            Random rnd = new Random();
            int randomIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                randomIndex = rnd.Next(11);
                Console.WriteLine($"{randomIndex} {Stars(randomIndex)}");
            }
            Console.ReadKey();
        }
        static string Stars(int numberOfStars)
        {
            string s = "";
            for (int i = 0; i < numberOfStars; i++)
            {
                s += "*";
            }
            return s;
        }
    }
}
