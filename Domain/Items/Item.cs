using System;
using Domain.Characters;

namespace Domain.Items
{
    public abstract class Item : Character
    {
        protected Character Character;

        protected Item(Character c, String name)
        {
            Character = c;
            this.Name = name;
        }
    }
}
