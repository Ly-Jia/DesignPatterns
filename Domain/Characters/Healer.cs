using System;
using Domain.AttackBehavior;

namespace Domain.Characters
{
    public class Healer : Character
    {
        public event EventHandler MagicCasting;

        public void OnCastSpell()
        {
            if (MagicCasting != null)
                MagicCasting(this, new HealingSpellArgs(this.Name, 5));
        }

        public Healer(string name, int hp, int mp, int strength, int intelligence, int defense, int magicResist) : base(name, hp, mp, strength, intelligence, defense, magicResist, new MagicAttackBehavior())
        {
        }
    }
}
