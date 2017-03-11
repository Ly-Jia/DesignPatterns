using System;
using Domain.Characters;

namespace Domain.AttackBehavior
{
    public class BonusMagicAttackBehavior : IAttackBehavior
    {
        public void Attack(Character attacker, Character attacked)
        {
            const int damages = 5;
            attacked.HP -= damages;
            Console.WriteLine("{0} a attaqué {1} avec {2} dommages magiques supplémentaires", attacker.Name, attacked.Name, damages);
        }
    }
}
