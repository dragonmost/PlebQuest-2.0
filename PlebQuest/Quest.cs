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

        public string Name { get; set; }
        public string Description { get; set; }

        public int ExpReward { get; set; }
        public int GoldReward { get; set; }

        public int RequiredLevel { get; set; }

        public Region Region { get; set; }
    }
}
