using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b;
            Console.WriteLine("Molq vavedete chislo");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Molq vavedete chislo");
            b = double.Parse(Console.ReadLine());
            double P = 0;
            P = (a + b) * 2;
            //double P=(a + b) * 2;
            Console.WriteLine("Obkolkata na figura sas strani {0} i {1} e {2}",a,b,P);
        }
    }
}
