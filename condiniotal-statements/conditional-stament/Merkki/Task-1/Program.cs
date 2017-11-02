using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string jono = "hello world!";
            Console.WriteLine(jono);
            Console.WriteLine($"Syötteessä on {jono.Length} merkkiä.");
            Console.ReadKey();
        }
    }
}
