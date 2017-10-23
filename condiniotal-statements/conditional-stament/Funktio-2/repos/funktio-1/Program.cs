using System;

namespace funktio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma antaa saman verran tähtiä kuin käyttäjän antama numero.");
            int number = 0;
            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Väärä syöte!");
                }
                else
                {
                    Console.WriteLine(Stars(number));
                }
            }
            while (number<0);
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
