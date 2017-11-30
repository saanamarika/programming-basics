using System;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Minäpä tiedän luvun väliltä 1-100, jota sinä et tiedä!");
            Random rnd = new Random();
            bool userInput;
            int i = 0;
            int nro = 0;
            int randomi = rnd.Next(1, 101);
            do
            {
                Console.Write("Arvaa luku: ");
                userInput = int.TryParse(Console.ReadLine(), out nro);
                if (nro < randomi || nro > randomi)
                {
                    
                    if (nro < randomi)
                    {
                        if (nro >= 1)
                        {
                            Console.WriteLine("Lukuni on isompi!");
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Epäkelpo luku!");
                        }
                    }
                    else
                    {
                        if (nro <= 100)
                        {
                            Console.WriteLine("Lukuni on pienempi!");
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Epäkelpo luku!");
                        }
                    }
                }

            }
            while (nro < randomi || nro > randomi || nro < 1 || nro > 100);
            Console.WriteLine($"Oikein! Arvauksia yhteensä: {i+1}");
            Console.ReadKey();

        }
    }
}
