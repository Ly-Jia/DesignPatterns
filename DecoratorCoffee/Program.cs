using System;
using DecoratorCoffee.Service;

namespace DecoratorCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu(new CoffeeSection(), new TeaSection());
            menu.Print();
            Console.ReadKey();
        }
    }
}
