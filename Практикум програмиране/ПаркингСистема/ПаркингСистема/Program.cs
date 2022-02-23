using System;

namespace ПаркингСистема
{
    class Program
    {

        static void Main(string[] args)
        {
            Assistant assistant = new Assistant();
            ConsoleT console = new ConsoleT(assistant);
            console.Start();
        }
    }
}
