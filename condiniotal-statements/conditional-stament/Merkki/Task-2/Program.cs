using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string line = "Vesihiisi sihisi hississä";
            Console.WriteLine(line);

            line=line.Replace('s', '@');
            Console.WriteLine(line);
            Console.ReadKey();
        }
    }
}
