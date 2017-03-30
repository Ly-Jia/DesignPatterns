using System;
using System.Collections.Generic;
using System.Linq;
using DecoratorCoffee.Domain;

namespace DecoratorCoffee
{
    public class Bill
    {
        public Bill(IList<Beverage> _beverages)
        {
            beverages = _beverages;
        }

        private IList<Beverage> beverages;

        public void Print()
        {
            Console.WriteLine("Welcome @ Decorator Coffee!");
            foreach (var beverage in beverages)
            {
                Console.WriteLine(beverage.Name + "-" + beverage.Cost + "$");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Total: " + beverages.Sum(x => x.Cost)+"$");
        }

    }
}
