using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("ohjelma kysyy käyttäjältä sanan tai lauseen ja katsoo onko se palintromi.");
            Console.Write("Syötä sana tai lause: ");
            string palli = Console.ReadLine();
            string palli2 = palli.Replace(" ", "");
            string palli3 = "";
            for(int i=palli2.Length-1; i>=0;i--)
            {
                palli3 += palli2[i];
            }
            if(palli3==palli2)
            {
                Console.WriteLine($"{palli} on palintromi");
            }
            else
            {
                Console.WriteLine($"{palli} ei ole palintromi");
            }
            

            Console.ReadKey();
        }
    }
}
