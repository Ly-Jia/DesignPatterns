using System;
using System.Collections.Generic;
using DecoratorCoffee.Domain;

namespace DecoratorCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            var darkCoffee = new DarkCoffee();
            var ristretto = new Ristretto();
            var icedTea = new IcedTea();

            var beverages = new List<Beverage> {darkCoffee, ristretto, icedTea};

            var bill = new Bill(beverages);

            bill.Print();

            Console.ReadKey();
        }
    }
}
