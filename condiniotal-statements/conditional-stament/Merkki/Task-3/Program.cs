using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Syötä sana tai lause: ");
            string input = Console.ReadLine().ToUpper();
            int chCount = 0;
            for(int i=0; i<input.Length;i++)
            {
                if (input[i]=='A')
                {
                    chCount++;
                }

            }
            Console.WriteLine($"Syötteessä {input} on {chCount} A-kirjainta");

            Console.ReadKey();
        }
    }
}
