using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.AttackBehavior;

namespace Domain.Characters
{
    public class Healer : Character, IGroupMagic
    {
        private IList<IMagicReceiver> group;

        public Healer(string name, int hp, int mp, int strength, int intelligence, int defense, int magicResist) : base(name, hp, mp, strength, intelligence, defense, magicResist, new MagicAttackBehavior())
        {
            group = new List<IMagicReceiver>();
        }


        public void AddGroupMember(IMagicReceiver receiver)
        {
            group.Add(receiver);
        }

        public void RemoveGroupMember(IMagicReceiver receiver)
        {
            group.Remove(receiver);
        }

        public void CastSpellOnGroup()
        {
            foreach (var magicReceiver in group)
            {
                Console.WriteLine(this.Name + " fait gagner 5 points de vie");
                magicReceiver.UpdateHP(5);
            }
        }
    }
}
