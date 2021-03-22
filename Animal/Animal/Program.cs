using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat1 = new Cat("Kitty", "Whiskas");
            Cat cat2 = new Cat("Hummor", "Mice");

            Animal dog1 = new Dog("Doggo", "Meat");
            Dog dog2 = new Dog("Mars", "Beef");

            Console.WriteLine(cat1.ExplainSelf());
            Console.WriteLine(cat2.ExplainSelf());

            Console.WriteLine(dog1.ExplainSelf());
            Console.WriteLine(dog2.ExplainSelf());

        }
    }
}
