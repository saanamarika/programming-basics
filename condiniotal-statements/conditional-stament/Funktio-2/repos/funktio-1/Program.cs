using System;

namespace funktio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma antaa saman verran tähtiä kuin käyttäjän antama numero.");
            //määritä int number ja bool num
            int number = 0;
            bool num = false;
            do
            {
                Console.Write("Syötä luku: ");
                //muista että jos käytät bool:ia niin laita bool ensin ja int out:in jälkeen
                num = int.TryParse(Console.ReadLine(), out number);
                // !num << tarkistetaan onko false vai true
                if (number < 0 || !num)
                {
                    Console.WriteLine("Väärä syöte!");
                }
                else
                {
                    Console.WriteLine(Stars(number));
                }
            }
            while (number<0 || !num);
            Console.ReadKey();


        }

        static string Stars(int numberOfStars)
        {
            string s = "";
            for (int i = 0; i < numberOfStars; i++)
            {
                s += "*";
            }
            return s;

        }

    }
}
