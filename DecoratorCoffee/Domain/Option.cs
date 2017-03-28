namespace DecoratorCoffee.Domain
{
    public class Option : Beverage
    {
        public Option(string name, double cost, Beverage b) : base(name, cost)
        {
            beverage = b;
        }

        protected Beverage beverage;
    }
}
