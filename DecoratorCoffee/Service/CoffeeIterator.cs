using System.Collections.Generic;
using System.Linq;
using DecoratorCoffee.Domain;

namespace DecoratorCoffee.Service
{
    public class CoffeeIterator : IBeverageIterator
    {
        private IList<Beverage> beverages;
        private int position = 0;

        public CoffeeIterator(IList<Beverage> items)
        {
            beverages = items;
        }

        public bool HasNext()
        {
            if (position >= beverages.Count)
                return false;
            return true;
        }

        public Beverage Next()
        {
            var beverage = beverages.ElementAt(position);
            position += 1;
            return beverage;
        }
    }
}
