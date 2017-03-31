using System.Collections.Generic;
using DecoratorCoffee.Domain;

namespace DecoratorCoffee.Service
{
    public class CoffeeSection : ISection
    {
        private IList<Beverage> items;
        public string Name { get; set; }

        public CoffeeSection()
        {
            items = new List<Beverage>
            {
                new DarkCoffee(),
                new Ristretto()
            };
            Name = "Coffee selection";
        }

        public IBeverageIterator CreateIterator()
        {
            return new CoffeeIterator(items);
        }
        
        public void AddBeverage(Beverage beverage)
        {
            items.Add(beverage);
        }
    }
}
