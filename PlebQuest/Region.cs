using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Region
    {
        private int ID;

        public string Name { get; private set; }
        public string Description { get; private set; }

        public List<Quest> AvailableQuests { get; private set; }
        public List<Item> SoldItems { get; private set; }
        public List<Mob> AvailableMobs { get; private set; }
        //Picture
    }
}
