using System;

namespace If2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Maatalousnäyttelyn lipunhinta");
            Console.Write("Nimi: ");
            Console.ReadLine();
            int discount = 0;
            int price = 16;
            bool discounted = false;
            Console.Write("ikä: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 7)
            {
                discount = 100;
                discounted = true;
            }
            else if (age >= 7 && age <= 15 && discounted == false)
            {
                discount = 50;
                discounted = true;
            }
            else if (age >= 65 && discounted == false)
            {
                discount = 50;
                discounted = true;
            }
            //muut alennukset
            if (age > 15 && age < 65)
            {
                Console.WriteLine("Oletko varusmies? Y/N");
                string conscriptResponse = Console.ReadLine();
                if (conscriptResponse == "Y" || conscriptResponse == "y" && discounted == false)
                {
                    discount = 50;
                    discounted = true;
                }
                else
                {
                    Console.WriteLine("Oletko Mtk:n jäsen? Y/N");
                    string mtkResponse = Console.ReadLine();
                    if (mtkResponse == "Y" || mtkResponse == "y" && discounted == false)
                    {
                        discount = 15;
                        discounted = true;
                    }
                    Console.WriteLine("Oletko opiskelija: Y/N");
                    string studentResponse = Console.ReadLine();
                    if (studentResponse == "Y" || studentResponse == "y" && discounted == false)
                    {
                        discount = 45;
                        discounted = true;
                    }
                    //erikoisehto
                    if (mtkResponse == "Y" || mtkResponse == "y")
                    {
                        if (studentResponse == "Y" || studentResponse == "y")
                        {
                            discount = 45 + 15;
                        }
                    }
                }       
            }
            //lopullisen hinnan laskeminen
            decimal lopullinen =(price-(price * Convert.ToDecimal(discount / 100m)));   
            Console.WriteLine("Lippusi hinta on: " + lopullinen);
            Console.WriteLine("Tervetuloa!");
            Console.ReadKey();

        }

    }
}











            
                














    