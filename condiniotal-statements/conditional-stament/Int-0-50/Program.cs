using System;

namespace Int_0_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0-50. Luvut tulostetaan 5/per rivi");
            Random rnd = new Random();

            for (int i=1; i<5; i++)
            {
                Console.Write($"Rivi{i}: ");
                for(int j=0; j<5; j++)
                {
                    if (j < 4)
                    {
                        Console.Write($"{rnd.Next(51)},");
                    }
                    else
                    {
                        Console.WriteLine($"{rnd.Next(51)}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
