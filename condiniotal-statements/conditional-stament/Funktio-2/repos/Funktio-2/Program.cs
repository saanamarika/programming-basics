using System;

namespace Funktio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma palauttaa arvonaan kahdesta luvusta pienemmän. Luvut välitetään funktiolle parametrinä");
            int number = 0;
            bool num1 = false;
            do
            {
                Console.Write("Syötä luku 1/2: ");
                num1 = int.TryParse(Console.ReadLine(), out number);
                if (!num1)
                {
                    Console.WriteLine("Olet hölmö.");
                }
            } while (!num1);
            int numb = 0;
            bool num2 = false;
            do
            {
                Console.Write("Syötä luku 2/2: ");
                num2 = int.TryParse(Console.ReadLine(), out numb);
                if (!num2)
                {
                    Console.WriteLine("Olet hölmö.");
                }
            } while (!num2);

            Console.WriteLine(Minimi(number, numb));
            Console.ReadKey();



        }
        //string silloin, kun tulee tekstiä ja int kun määritellään numeroita
        static string Minimi(int x, int y)
        {
            if (x<y)
            {
                return ($"Luku {x} on pienempi kuin {y}");
            }
            else
            {
                return ($"Luku {y} on pienempi kuin {x}");
            }
        }
    }
}
