using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Kak se kazva liceto:");
                string name = null;//="";
                name = Console.ReadLine();
                Console.WriteLine("Koq godina e rodeno?");
                int godinaNaRajdane = int.Parse(Console.ReadLine());
                Console.WriteLine("Koq godina e sega?");
                int godina = int.Parse(Console.ReadLine());
                double age = godina - godinaNaRajdane;
                Console.WriteLine("{0} e na {1} godini", name, age);
            //if (age < 18)
            //{
            //    if (age < 1)
            //    {
            //        Console.WriteLine("Ivan moje bi oshte ne e roden");
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} e uchenik", name);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ivan e rabotnik");
            //}

            if (age==0)
            {
                Console.WriteLine("Liceto oshte ne e rodeno");
            }
            else if (age >0 && age < 1)
            {
                Console.WriteLine("Liceto e bebe");
            }
            else if(age <18)
            {
                Console.WriteLine("liceto e uchenik");
            }
            else
            {
                Console.WriteLine("liceto e rabotnik");
            }


            
           
            
               
        }
    }
}
