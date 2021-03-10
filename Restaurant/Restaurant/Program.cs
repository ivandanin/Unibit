using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Assistant assistant = new Assistant();
            Terminal terminal = new ConsoleT(assistant);
            terminal.Start();
        }
    }
}
