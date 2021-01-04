using System;

namespace ConsoleApp7
{
    class Program
    {
        public static void PrintMessage() 
        {
            Console.WriteLine("Molq vavedi za broistudenti");
        }

        public static void PrintMessage(int i)
        {
            Console.WriteLine("Molq vavedi danni za {0} student",i);
        }

        public static string Name()
        {
            Console.WriteLine("eto tuk sme v metoda");
            string s = Console.ReadLine();
            return s;
        }
        static void Main(string[] args)
        {
            Program.PrintMessage();
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (true)
            {
                Program.PrintMessage(i);
                string name = Console.ReadLine();
                Program.PrintMessage(i);
                string family = Program.Name();
                Program.PrintMessage(i);
                string age = Console.ReadLine();
                Console.WriteLine("Studenta se kazva {0} {1} i e na {2} godini", name, family, age);
               
                if (i >= n) break;
                i++;


            }
            }
    }
}
