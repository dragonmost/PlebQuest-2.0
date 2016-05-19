using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Region
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public List<Quest> AvailableQuests { get; set; }
        public List<Item> SoldItems { get; set; }
        public List<Mob> AvailableMobs { get; set; }
    }
}
