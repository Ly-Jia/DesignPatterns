using System;

namespace DecoratorCoffee.Service
{
    public class Menu
    {
        private CoffeeSection coffees;
        private TeaSection teas;

        public Menu(CoffeeSection coffeeSection, TeaSection teaSection)
        {
            coffees = coffeeSection;
            teas = teaSection;
        }

        public void Print()
        {
            PrintSection(coffees);
            PrintSection(teas);
        }

        private void PrintSection(ISection section)
        {
            Console.WriteLine("------------");
            Console.WriteLine(section.Name);
            Console.WriteLine("------------");
            var iterator = section.CreateIterator();
            while (iterator.HasNext())
            {
                var item = iterator.Next();
                Console.WriteLine(item.Name + "-" + item.Cost + "$");
            }
        }
        
    }
}
