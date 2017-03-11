using System;
using Domain.Characters;

namespace Domain.AttackBehavior
{
    public class MagicAttackBehavior : IAttackBehavior
    {
        public void Attack(Character attacker, Character attacked)
        {
            var damages = attacker.Intelligence - attacked.MagicResist;
            attacked.HP -= damages;
            Console.WriteLine("{0} a attaqué {1} avec {2} dommages magiques", attacker.Name, attacked.Name, damages);
        }
    }
}
