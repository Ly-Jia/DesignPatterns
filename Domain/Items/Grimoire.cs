using System;
using Domain.AttackBehavior;
using Domain.Characters;

namespace Domain.Items
{
    public class Grimoire : Item
    {
        public Grimoire(Character c) : base(c, String.Format("{0} avec {1}", c.Name, "le grimoire"))
        {
            this.attackBehavior = new BonusMagicAttackBehavior();
        }

        public override void Attack(Character c)
        {
            this.Character.Attack(c);
            Console.WriteLine("Le grimoire de {0} fait +5 de dommages magiques en plus!", this.Character.Name);
            attackBehavior.Attack(this.Character, c);
        }
    }
}
