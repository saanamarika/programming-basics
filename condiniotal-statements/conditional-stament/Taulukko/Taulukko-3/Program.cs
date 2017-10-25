using System;

namespace Taulukko_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo yksiulotteiseen taulukkoon kokonaislukuja. Taulukon arvot 0-20");
            Random rnd = new Random();
           
            int[] one = new int[10];
            Console.WriteLine("[x]=Arvo");
            for(int i=0; i<one.Length;i++)
            {
                one[i] = rnd.Next(20);
                Console.WriteLine($"[{i}]={one[i]:00}");
            }
            Console.ReadKey();
        }
    }
}
