using System;

namespace Funktio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma palauttaa arvonaan kahdesta luvusta pienemmän. Luvut välitetään funktiolle parametrinä");
            Console.Write("Syötä luku 1/2: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Syötä luku 2/2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Minimi(num1, num2));
            Console.ReadKey();



        }
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
