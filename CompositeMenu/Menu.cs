using System;
using System.Collections.Generic;

namespace CompositeMenu
{
    public class Menu : IMenuComponent
    {
        private IList<IMenuComponent> components;

        public string Name { get; set; }

        public Menu(string name)
        {
            Name = name;
            components = new List<IMenuComponent>();
        }

        public void Print()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine(Name);
            Console.WriteLine("---------------------------");
            foreach (var component in components)
            {
                component.Print();
            }
            Console.WriteLine("**************************");
        }

        public void Add(IMenuComponent menuComponent)
        {
             components.Add(menuComponent);
        }
    }
}
