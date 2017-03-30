using System.Collections.Generic;
using DecoratorCoffee.Domain;

namespace DecoratorCoffee.Service
{
    public class CoffeeSection
    {
        public IList<Beverage> Items { get; private set; }

        public CoffeeSection()
        {
            Items = new List<Beverage>
            {
                new DarkCoffee(),
                new Ristretto()
            };
        }

        public void AddBeverage(Beverage beverage)
        {
            Items.Add(beverage);
        }
    }
}
