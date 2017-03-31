namespace DecoratorCoffee.Service
{
    public interface ISection
    {
        string Name { get; set; }
        IBeverageIterator CreateIterator();
    }
}
