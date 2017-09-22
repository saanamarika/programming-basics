using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma lajittelee luvut nousevaan järjestykseen. Anna ohjelmalle kolme lukua");
            Console.Write("Syötä luku 1/3: ");
            // define variables
            string userInput;
            userInput = Console.ReadLine();

            int numberX;
            int.TryParse(userInput, out numberX);

            Console.Write("Syötä luku 2/3: ");
          
            userInput = Console.ReadLine();

            int numberY;
            int.TryParse(userInput, out numberY);

            Console.Write("Syötä luku 3/3: ");

            userInput = Console.ReadLine();

            int numberZ;
            int.TryParse(userInput, out numberZ);

            if(numberX < numberY)
            {
                if (numberX < numberZ)
                { 

                    if (numberY < numberZ)
                    {
                        Console.WriteLine($"{numberX} {numberY} {numberZ}");
                    }
                    else
                    {
                        Console.WriteLine($"{numberX} {numberZ} {numberY}");
                    }
                }
                else
                {
                    Console.WriteLine($"{numberZ} {numberX} {numberY}");
                }
            }
            else
            {
                if (numberX < numberZ)
                {
                    Console.WriteLine($"{numberY} {numberX} {numberZ}");
                }
                else
                {
                    if(numberY<numberZ)
                    {
                        Console.WriteLine($"{numberY} {numberZ} {numberX}");
                    }
                    else
                    {
                        Console.WriteLine($"{numberZ} {numberY} {numberX}");
                    }
                }
          
            
            } Console.ReadKey();
         


        }
    }
}
