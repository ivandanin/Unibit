using System.Text;

namespace Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, string favoriteFood) 
            : base(name, favoriteFood)
        {
        }
        public override string ExplainSelf()
        {
            StringBuilder output = new StringBuilder(base.ExplainSelf());
            output.Append("BARK!");

            return output.ToString();
        }
    }
}