using System;

namespace Domain.Characters
{
    public class HealingSpellArgs : EventArgs
    {
        public HealingSpellArgs(string caster, int hp)
        {
            Caster = caster;
            HP = hp;
        }

        public string Caster { get; private set; }
        public int HP { get; private set; }
    }
}
