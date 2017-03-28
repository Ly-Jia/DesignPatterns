namespace DecoratorCoffee.Domain
{
    public abstract class Beverage
    {
        protected Beverage(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
        public virtual string Name { get; private set; }
        public virtual double Cost { get; private set; }
    }
}
