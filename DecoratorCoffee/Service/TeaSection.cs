using System;
using DecoratorCoffee.Domain;

namespace DecoratorCoffee.Service
{
    public class TeaSection
    {
        public Beverage[] Items { get; private set; }
        private readonly int MAX_ITEMS = 4;
        private int numberOfItems;

        public TeaSection()
        {
            Items = new Beverage[MAX_ITEMS];
            Items[0] = new EarlGrey();
            Items[1] = new IcedTea();
            numberOfItems = 2;
        }

        public void AddItem(Beverage beverage)
        {
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, section is already full!");
            }
            else
            {
                Items[numberOfItems] = beverage;
                numberOfItems += 1;
            }
        }
    }
}
