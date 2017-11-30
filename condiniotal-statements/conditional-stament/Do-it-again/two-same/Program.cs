using System;

namespace twosame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma pyytää syöttämään lukuja kunnes syötät kaksi samaa lukua, jonka jälkeen ohjelma laskee lukujen yhteissumman.");
            int num = 0;
            int sum = 0;
            int oldNumber = 234;
            do
            {
                Console.Write("Syötä luku: ");
                num = int.Parse(Console.ReadLine());
                if (oldNumber == num)
                    break;
                else
                    oldNumber = num;
                sum += num;
            }
            while (true);
            Console.WriteLine($"Lukujen summa on: {sum}");
            Console.ReadKey();
        }
    }
}

