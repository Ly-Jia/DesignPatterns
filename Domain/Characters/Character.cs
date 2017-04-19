using Domain.AttackBehavior;

namespace Domain.Characters
{
    public abstract class Character
    {
            
        public Character(string name, int hp, int mp, int strength, int intelligence, int defense, int magicResist, IAttackBehavior attackBehavior)
        {
            Name = name;
            HP = hp;
            MP = mp;
            Strength = strength;
            Intelligence = intelligence;
            Defense = defense;
            MagicResist = magicResist;
            this.attackBehavior = attackBehavior;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Defense { get; set; }
        public int MagicResist { get; set; }
        protected IAttackBehavior attackBehavior;

        protected Character()
        {
        }

        public virtual void Attack(Character character)
        {
            attackBehavior.Attack(this, character);
        }

        public bool IsAlive()
        {
            return HP > 0;
        }
    }
}
