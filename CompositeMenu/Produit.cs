using System;

namespace CompositeMenu
{
    public class Produit : IMenuComponent
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public Produit (string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
        public void Print()
        {
            Console.WriteLine(Name + " - " + Cost + "$");
        }
    }
}
