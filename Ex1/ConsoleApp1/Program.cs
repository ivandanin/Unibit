using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=4;
            float A = 2;//1 stojnost
            double b=3.45;//1 stoinost
            //komentar
            string S= "Kostadinova";//simvolen niz
            char C = 'I';//1 simvol
            int[] M = new int[3];//ednomeren masiv,mnogo stoinosti
            Console.WriteLine("Hello student");
            Console.WriteLine(a);
            Console.WriteLine("float A="+A);
            Console.WriteLine("float A={0} i e razlichno ot {1}" , A,a);
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("V c ima "+c);
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("novata stoinost na a e {0}",a);
        }
    }
}
