using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Characters;

namespace Service
{
    public class Game
    {
        public Game(List<Character> teamA, List<Character> teamB)
        {
            TeamA = teamA;
            TeamB = teamB;
        }

        public List<Character> TeamA { get; private set; }
        public List<Character> TeamB { get; private set; }

        public void PlayTurn()
        {
            foreach (var character in TeamA)
            {
                var enemy = TeamB.ElementAt(TeamA.IndexOf(character));
                character.Attack(enemy);
                enemy.Attack(character);
            }
        }

        public bool HasEnded()
        {
            return TeamA.TrueForAll(c => !c.IsAlive()) || TeamB.TrueForAll(c => !c.IsAlive());
        }

        public void DisplayScore()
        {
            var winner = TeamA.TrueForAll(c => !c.IsAlive()) ? TeamA : TeamB;

            var builder = new StringBuilder();
            foreach (var character in winner)
            {
                builder.Append(character.Name);
                builder.Append(", ");
            }

            Console.WriteLine("L'équipe avec {0}a gagné !", builder);
        }
    }
}
