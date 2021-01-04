using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumator = 0;
            Console.WriteLine("kolko produkta shte si kupite?");
            int n = int.Parse(Console.ReadLine());
            //int i = 1;
            while (true)
            {
                Console.WriteLine("product?");
                string s = Console.ReadLine();
                Console.WriteLine("cena?");
                double price = double.Parse(Console.ReadLine());
                sumator = sumator + price;
                Console.WriteLine("Iskate li da platite?");
                string Y = Console.ReadLine().ToLower();
                if (Y == "yes"||Y=="da") break;
            }
            //===================================================
            //int i = 1;
            //while(i<=n)
            //{
            //    Console.WriteLine("kakav e {0}-iq vi produkt", i);
            //    string product = Console.ReadLine();
            //    Console.WriteLine("Kolko struva?");
            //    double price = double.Parse(Console.ReadLine());
            //    sumator = sumator + price;
            //    i++;

            //}
            //============================================
            //for(int i=1;i<=n;i=i+1)//i++
            //{

            //    Console.WriteLine("kakav e {0}-iq vi produkt",i);
            //    string product = Console.ReadLine();
            //    Console.WriteLine("Kolko struva?");
            //    double price = double.Parse(Console.ReadLine());
            //    sumator = sumator + price;
            //}

            Console.WriteLine("trqbva da platite "+sumator+ " lv.");
        }
    }
}
