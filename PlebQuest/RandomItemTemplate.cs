using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    public class RandomItemTemplate : IItemTemplate
    {
        public string Name { get; }
        public CharacterStatsRange StatsRange { get; }
        public ItemRequirements Requirements { get; }

        public RandomItemTemplate(string name, CharacterStatsRange statsRange, ItemRequirements requirements)
        {
            Name = name;
            StatsRange = statsRange;
            Requirements = requirements;
        }

        public Item Create(GameContext context)
        {
            return new Item(Name)
            {
                Stats = new()
                {
                    CharacterStats = StatsRange.Create(context)
                },
                Requirements = Requirements
            };
        }
    }
}
