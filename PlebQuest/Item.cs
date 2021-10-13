using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    public record class Item
    {
        public string Name { get; init; }

        public ItemStats Stats { get; init; }

        public ItemRequirements Requirements { get; init; }

        public Item(string name)
        {
            Name = name;
        }
    }
}
