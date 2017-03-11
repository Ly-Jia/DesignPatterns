using Domain.Characters;

namespace Domain.AttackBehavior
{
    public interface IAttackBehavior
    {
        void Attack(Character attacker, Character attacked);
    }
}
