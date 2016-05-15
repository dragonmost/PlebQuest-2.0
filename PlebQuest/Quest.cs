using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Quest
    {
        private int ID;

        public string Name { get; private set; }
        public string Description { get; private set; }

        public int ExpReward { get; private set; }
        public int GoldReward { get; private set; }

        public int RequiredLevel { get; private set; }

        public Region Region { get; set; }
    }
}
