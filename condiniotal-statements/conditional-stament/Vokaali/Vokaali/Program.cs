using System;

namespace Vokaali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee syöttämäsi sanan tai lauseen vokaalien lukumäärän");
            Console.Write("Syötä data: ");
            string voka = Console.ReadLine();
            string voka2 = voka.ToUpperInvariant;
            string voka7 = voka.Replace(" ", "");
            int voka3 = voka.Length;
             voka2 = voka.Replace("A","");
             voka2 = voka.Replace("E", "");
             voka2 = voka.Replace("I", "");
             voka2 = voka.Replace("U", "");
             voka2 = voka.Replace("Y", "");
             voka2 = voka.Replace("Ä", "");
             voka2 = voka.Replace("Ö", "");

            int voka5 = voka2.Length;
            int voka6 = voka3 - voka5;

            Console.WriteLine($"Syötteessä {voka} on {voka6} vokaalia");
            Console.ReadLine();
        
        }
    }
}
