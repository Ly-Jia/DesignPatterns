namespace DecoratorCoffee.Domain
{
    public class Chantilly : Option
    {
        public Chantilly(Beverage _beverage) : base("Chantilly", 1, _beverage)
        {
            beverage = _beverage;
        }

        public override string Name
        {
            get { return beverage.Name + ", " + base.Name; }
        }

        public override double Cost
        {
            get { return beverage.Cost + base.Cost; }
        }
    }
}
