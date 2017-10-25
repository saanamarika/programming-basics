using System;

namespace Taulukko_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma antaa 3 taulukkoa mistä 2 ensimmäisen lukuja verrataan keskenään ja tulostetaan 3. taulukkoon oikeille kohdille");
            int[] arrT_0 = new int[10];
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];
            Random rnd = new Random();
            
            
            for(int i=0; i<arrT_1.Length;i++)
            {
                arrT_0[i] = i + 1;
                arrT_1[i] = rnd.Next(50);
            }
            for(int j=0; j<arrT_2.Length;j++)
            {
                arrT_2[j] = rnd.Next(50);
            }
            for(int k = 0; k < arrT_3.Length; k++)
            {
                if(arrT_1[k]<arrT_2[k])
                {
                    arrT_3[k] = arrT_2[k];
                }
                else
                {
                    arrT_3[k] = arrT_1[k];
                }
            }
            //tästä alkaa tulostus
            Console.WriteLine($"      \t{printArray(arrT_0)}");
            Console.WriteLine("        -----------------------------");
            Console.WriteLine($"arrT_1\t{printArray(arrT_1)}");
            Console.WriteLine($"arrT_2\t{printArray(arrT_2)}");
            Console.WriteLine($"arrT_3\t{printArray(arrT_3)}");
            Console.ReadKey();
        }
        static string printArray(int[]xxx)
        {
            string ret = string.Empty;
            for(int i=0; i<xxx.Length;i++)
            {
                ret+=($"{xxx[i]:00} ");
            }
            return ret;
        }
    }
}
