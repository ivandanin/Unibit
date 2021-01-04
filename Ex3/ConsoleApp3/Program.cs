using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kak se kazva liceto:");
            string name = null;//="";
            name = Console.ReadLine();
            Console.WriteLine("Koq godina e rodeno?");
            double godinaNaRajdane = double.Parse(Console.ReadLine());
            Console.WriteLine("Koq godina e sega?");
            int godina = int.Parse(Console.ReadLine());
            double age = godina - godinaNaRajdane;
            Console.WriteLine("{0} e na {1} godini", name, age);
            //Console.WriteLine((int)age);
            //double number = 1.53467876;
            //Console.WriteLine("chisloto e "+number);
            //Console.WriteLine("nadolu "+Math.Floor(number));//nadolu do cqlo chislo
            //Console.WriteLine("nagore " + Math.Ceiling(number));//nagore do cqlo chislo
            //Console.WriteLine("otrqzva " + Math.Truncate(number));//otrqzva do cqlo chislo
            //Console.WriteLine("zakryglqva " + Math.Round(number));//otrqzva do cqlo chislo
            //Console.WriteLine("zakryglqva s tochnost do  " + Math.Round(number,3));//otrqzva do cqlo chislo
            //Console.WriteLine(number +Math.PI);
        }
    }
}
