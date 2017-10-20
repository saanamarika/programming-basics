using System;

namespace Coin_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //opettele ulkoa tämä mikä määrittää ääkköset
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy montako kertaa heitetään kolikkoa ja vastaa kuinka monta kruunaa ja monta klaavaa");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            //muista määrittää userInput numeroksi, jos sitä käytetään numerona, ei toimi muuten.
            int number = int.Parse(userInput);
            Random rand = new Random();
            int klaava = 0;
            int kruuna = 0;
            //esimerkki alapuolella for-lausekkeesta
            for (int i = 1; i <= number; i++)
            {
                if (rand.Next(2)==1)
                {
                    klaava++;
                }
                else
                {
                    kruuna++;
                }
            }
            //rivinvaihto toimi \n << tuolla 
            Console.WriteLine($"Kolikkoa heitettiin: {number} kertaa \nklaavoja {klaava} ja kruunia {kruuna}");
            Console.WriteLine("Kiitos!");
            Console.ReadKey();
        }
    }
}
