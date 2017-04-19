using System;
using Domain.AttackBehavior;

namespace Domain.Characters
{
    public class Mage : Character, IMagicReceiver
    {
        public Mage(string name, int hp, int mp, int strength, int intelligence, int defense, int magicResist, int ip)
            : base(name, hp, mp, strength, intelligence, defense, magicResist, new MagicAttackBehavior())
        {
            IP = ip;
        }

        public int IP { get; set; }
        public void UpdateHP(int hp)
        {
            Console.WriteLine(this.Name + "a gagné " + hp );
            this.HP += hp;
        }
    }
}