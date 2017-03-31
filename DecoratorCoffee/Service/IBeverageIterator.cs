using DecoratorCoffee.Domain;

namespace DecoratorCoffee.Service
{
    public interface IBeverageIterator
    {
        bool HasNext();
        Beverage Next();
    }
}
