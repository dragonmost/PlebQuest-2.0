using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    public class UniqueItemTemplate : IItemTemplate
    {
        public Item Item { get; init; }

        public UniqueItemTemplate(Item item)
        {
            Item = item;
        }

        public Item Create(GameContext context)
        {
            return Item with { };
        }
    }
}
