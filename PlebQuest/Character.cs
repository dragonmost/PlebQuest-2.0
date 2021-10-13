using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    public record class Character
    {
        public string FirstName { get; init; } = "";
        public string LastName { get; init; } = "";

        public CharacterStats Stats { get; init; }
    }

    public record struct CharacterStats
    {
        public int Strength { get; init; }
        public int Intelligence { get; init; }
        public int Charisma { get; init; }
        public int Wisdom { get; init; }
        public int Dexterity { get; init; }
        public int Constitution { get; init; }
    }

    public record struct CharacterStatsRange
    {
        public CharacterStats Min { get; init; }
        public CharacterStats Max { get; init; }

        public CharacterStats Create(GameContext context) => new()
        {
            Strength = context.Random.Next(Min.Strength, Max.Strength),
            Intelligence = context.Random.Next(Min.Intelligence, Max.Intelligence),
            Wisdom = context.Random.Next(Min.Wisdom, Max.Wisdom),
            Charisma = context.Random.Next(Min.Charisma, Max.Charisma),
            Dexterity = context.Random.Next(Min.Dexterity, Max.Dexterity),
            Constitution = context.Random.Next(Min.Constitution, Max.Constitution),
        };
    }
}
