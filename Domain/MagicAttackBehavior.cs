using System;

namespace Domain
{
    public class MagicAttackBehavior : IAttackBehavior
    {
        public void Attack(Character attacker, Character attacked)
        {
            attacked.HP -= attacker.Strength*attacker.MP/2;
            Console.WriteLine("{0} a attaqué {1} avec {2} dommages magiques", attacker.Name, attacked.Name, attacker.Strength);
        
        }
    }
}
