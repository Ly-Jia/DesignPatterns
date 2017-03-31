using System;
using DecoratorCoffee.Domain;

namespace DecoratorCoffee.Service
{
    public class TeaSection : ISection
    {
        private Beverage[] items;
        private readonly int MAX_ITEMS = 4;
        private int numberOfItems;
        public string Name { get; set; }

        public TeaSection()
        {
            items = new Beverage[MAX_ITEMS];
            items[0] = new EarlGrey();
            items[1] = new IcedTea();
            numberOfItems = 2;
            Name = "Tea selection";
        }

        public IBeverageIterator CreateIterator()
        {
            return new TeaIterator(items);
        }

        public void AddItem(Beverage beverage)
        {
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, section is already full!");
            }
            else
            {
                items[numberOfItems] = beverage;
                numberOfItems += 1;
            }
        }
    }
}
