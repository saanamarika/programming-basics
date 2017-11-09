using System;

namespace Kertaus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma pyytää syöttämään lukuja kunnes syötät -1, jonka jälkeen ohjelma laskee lukujen yhteissumman.");
            int num = 0;
            int sum = 0;
            do
            {
                sum += num;
                Console.Write("Syötä luku: ");
                num = int.Parse(Console.ReadLine());
                
            }
            while (num > 0 || num < -2);
            Console.WriteLine($"Lukujen summa on: {sum}");
            Console.ReadKey();
            
        }
    }
}
