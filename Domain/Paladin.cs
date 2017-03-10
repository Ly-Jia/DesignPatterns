namespace Domain
{
    public class Paladin : Character
    {
        public Paladin(string name, int hp, int mp, int strength, int intelligence, int defense, int magicResist)
            : base(name, hp, mp, strength, intelligence, defense, magicResist, new StrengthAttackBehavior())
        {
        }
    }
}
