using DecoratorCoffee.Domain;

namespace DecoratorCoffee.Service
{
    public class TeaIterator : IBeverageIterator
    {
        private Beverage[] beverages;
        private int position = 0;

        public TeaIterator(Beverage[] items)
        {
            beverages = items;
        }

        public bool HasNext()
        {
            if (position >= beverages.Length || beverages[position] == null)
                return false;
            return true;
        }

        public Beverage Next()
        {
            var beverage = beverages[position];
            position += 1;
            return beverage;
        }
    }
}
