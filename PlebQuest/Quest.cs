using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Quest
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public int ExpReward { get; set; }
        public int GoldReward { get; set; }

        public Region Region { get; set; }
    }
}
