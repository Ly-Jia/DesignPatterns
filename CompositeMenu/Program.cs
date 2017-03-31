using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeeMenu = new Menu("Coffees");
            coffeeMenu.Add(new Produit("dark coffee", 5));
            coffeeMenu.Add(new Produit("ristretto", 5));

            var teaMenu = new Menu("Teas");
            teaMenu.Add(new Produit("earl", 5));
            teaMenu.Add(new Produit("darj", 5));

            var menu = new Menu("All Menus");
            menu.Add(coffeeMenu);
            menu.Add(teaMenu);
            menu.Add(new Produit("gateau", 10));

            menu.Print();

            Console.ReadKey();
        }
    }
}
