namespace Domain
{
    public class Mage : Character
    {
        public Mage(string name, int hp, int mp, int strength, int intelligence, int defense, int magicResist, int ip)
            : base(name, hp, mp, strength, intelligence, defense, magicResist, new MagicAttackBehavior())
        {
            IP = ip;
        }

        public int IP { get; set; }
    }
}