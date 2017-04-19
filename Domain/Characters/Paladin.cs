using System;
using Domain.AttackBehavior;

namespace Domain.Characters
{
    public class Paladin : Character, IMagicReceiver
    {
        public Paladin(string name, int hp, int mp, int strength, int intelligence, int defense, int magicResist)
            : base(name, hp, mp, strength, intelligence, defense, magicResist, new StrengthAttackBehavior())
        {
        }

        public void UpdateHP(int hp)
        {
            var result = hp - 2;
            Console.WriteLine("seulement " + result);
            this.HP += result;
        }
    }
}
