using System;

namespace Domain
{
    public class StrengthAttackBehavior : IAttackBehavior
    {
        public void Attack(Character attacker, Character attacked)
        {
            attacked.HP -= attacker.Strength;
            Console.WriteLine("{0} a attaqué {1} avec {2} dommages physiques", attacker.Name, attacked.Name, attacker.Strength);
        }
    }
}
