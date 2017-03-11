using System;
using Domain.Characters;

namespace Domain.Items
{
    public class Sword : Item
    {
        public Sword(Character c) : base(c, String.Format("{0} avec {1}", c.Name, "l'épée"))
        {
        }

        public override void Attack(Character c)
        {
            Console.WriteLine("L'épée permet à {0} d'attaquer deux fois !", this.Character.Name);
            this.Character.Attack(c);
            this.Character.Attack(c);
        }
    }
}
