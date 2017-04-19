using System;
using System.Collections.Generic;
using Domain.Characters;
using Domain.Items;
using Service;

namespace DesignPatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var popoi = new Mage("Popoi", 50, 80, 10, 5, 5, 30, 50);
            var popoiWithGrimoire = new Grimoire(popoi);
            var link = new Mage("Link", 50, 80, 10, 5, 5, 30, 50);
            var psyduck = new Healer("Psyduck", 50, 80, 10, 5, 5, 30);
            psyduck.AddGroupMember(link);
            psyduck.AddGroupMember(popoi);

            var chopper = new Sword(new Warrior("Chopper", 50, 80, 10, 5, 5, 30, 50));
            var johnDoe = new Paladin("johnDoe", 50, 20, 60, 12, 50, 2);
            var mike = new Paladin("mike", 50, 20, 60, 12, 50, 2);

            var game = new Game(
                new List<Character> { popoiWithGrimoire, link, johnDoe },
                new List<Character> { psyduck, chopper, mike });

            while (!game.HasEnded())
            {
                game.PlayTurn();
            }

            game.DisplayScore();

            Console.ReadKey();
        }
    }
}
