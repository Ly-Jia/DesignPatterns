using System;
using Domain.Characters;

namespace Domain.AttackBehavior
{
    public class StrengthAttackBehavior : IAttackBehavior
    {
        public void Attack(Character attacker, Character attacked)
        {
            var damages = attacker.Strength - attacked.Defense;
            attacked.HP -= damages;
            Console.WriteLine("{0} a attaqué {1} avec {2} dommages physiques", attacker.Name, attacked.Name, damages);
        }
    }
}
