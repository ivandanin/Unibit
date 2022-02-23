namespace ПаркингСистема
{
     public class Car : Vehicle
    {
        public Car()
        {
            this.WeightClass = WeightClass.LIGHT;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public WeightClass WeightClass { get; private set; }
    }
}