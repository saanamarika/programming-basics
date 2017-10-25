using System;

namespace taulukko_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo kaksiuloitteiseen taulukkoon kokonaislukuja väliltä 0-100, taulukon koko on 10 ja 20. Tuloste alle 10 luvuissa 00-09");
            int[,] one = new int[10,20];
            int tmp = one.GetUpperBound(0);
            Random rnd = new Random();
            Console.WriteLine("[X,Y]=Arvo");
            for(int i=0; i<one.GetUpperBound(0)+1; i++)
            {
                for(int j=0; j< one.GetUpperBound(1) + 1; j++)
                {
                    one[i,j] = rnd.Next(100);
                    Console.WriteLine($"[{i},{j}]={one[i,j]:00}");

                }
            }
            Console.ReadKey();
        }
    }
}
