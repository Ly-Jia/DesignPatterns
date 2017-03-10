using System;
using System.Collections.Generic;
using Domain;

namespace DesignPatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var popoi = new Mage("Popoi", 50, 80, 10, 5, 5, 30, 50);
            var link = new Warrior("Link", 50, 80, 10, 5, 5, 30, 50);
            var psyduck = new Mage("Psyduck", 50, 80, 10, 5, 5, 30, 50);
            var chopper = new Warrior("Chopper", 50, 80, 10, 5, 5, 30, 50);
            var johnDoe = new Paladin("johnDoe", 50, 20, 60, 12, 50, 2);
            var mike = new Paladin("mike", 50, 20, 60, 12, 50, 2);

            var game = new Game(
                new List<Character> { popoi, link, johnDoe },
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
