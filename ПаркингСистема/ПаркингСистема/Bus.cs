namespace ПаркингСистема
{
    public class Bus : Vehicle
    {
        public Bus()
        {
            this.WeightClass = WeightClass.MEDIUM;
        }
    public string Make { get; set; }
    public string Model { get; set; }
    public WeightClass WeightClass { get; private set; }
    }
}
