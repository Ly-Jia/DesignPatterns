namespace Domain
{
    public class Warrior : Character
    {
        public Warrior(string name, int hp, int mp, int strength, int intelligence, int defense, int magicResist, int ap)
            : base(name, hp, mp, strength, intelligence, defense, magicResist, new StrengthAttackBehavior())
        {
            AP = ap;
        }

        public int AP { get; set; }
    }
}