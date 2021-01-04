using System;

namespace ConsoleApp8
{
    class Program
    {
        static double Sumator (double sum,double price)
        {
            
            sum += price;
            return sum;
        }
        static void Main(string[] args)
        {
            double s = 0;
            while (true)
            {
                Console.WriteLine("product?");
                string product = Console.ReadLine();
                Console.WriteLine("cena?");
                double cena = double.Parse(Console.ReadLine());
                s = Sumator(s, cena);
                Console.WriteLine("sum=" + s);
                Console.WriteLine("prodaljavate li da pazaruvate?");
                string r = Console.ReadLine().ToUpper();
                if (r == "NO" || r == "NE") break;
                
               
            }
        }
    }
}
