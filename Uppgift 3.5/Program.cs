using System;

namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett till tal");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string räknesätt = Console.ReadLine();

            switch(räknesätt)
            {
                case "1.":
                    int summa = tal1 + tal2;
                    Console.WriteLine($"Summan av de två talen är {summa}.");
                        break;
                case "2.":
                    int differens = tal1 - tal2;
                    Console.WriteLine($"Differensen av de två talen är {differens}");
                    break;
                case "3.":
                    int produkt = tal1 * tal2;
                    Console.WriteLine($"Produkten av de två talen är {produkt}.");
                    break;
                case "4.":
                    int kvot = tal1 / tal2;
                    Console.WriteLine($"Kvoten av de två talen är {kvot}.");
                    break;
            } 

            Console.ReadKey();

        }
    }
}