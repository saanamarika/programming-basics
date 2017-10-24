using System;

namespace taulukko_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo 100 lukua 0-50 väliltä ja laskee niiden keskiarvon.");
            int[] iT = new int[100];
            double sum = 0;
            double avg = 0;
            Random rnd = new Random();
            for(int i=0; i<iT.Length; i++)
            {
                iT[i]=rnd.Next(51);
            }
            for (int i=0; i<iT.Length;i++)
            {
                sum += iT[i];
            }
            avg = sum / iT.Length;
            for(int i = 0; i < iT.Length; i++)
            {
                Console.WriteLine($"{i+1}.\t{iT[i]}");
            }

            Console.WriteLine($"\nKa.= {avg}");

            Console.ReadKey();
        }
    }
}
