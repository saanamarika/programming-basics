using System;

namespace Vokaali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee syöttämäsi sanan tai lauseen vokaalien lukumäärän");
            string voka = "AEIOUYÄÖ";
            Console.Write("Syötä data: ");
            string userInput = Console.ReadLine().ToUpper();
            int sum = 0;

            for(int i=0;i<userInput.Length;i++)
            {
                for(int j=0;j<voka.Length;j++)
                {
                    if(userInput[i]==voka[j])
                    {
                        sum++;
                    }
                }          
            }
            Console.WriteLine($"Syötteessä {userInput} on {sum} vokaalia");
            Console.ReadLine();
        
        }
    }
}
