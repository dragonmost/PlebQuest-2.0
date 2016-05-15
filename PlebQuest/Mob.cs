using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Mob
    {
        private int ID;

        public string Name { get; private set; }
        public int Level { get; private set; }
        public int BaseExp { get; private set; }
        public int BaseGold { get; private set; }

        public Stats Stats { get; private set; }

        private List<Item> drops;

        private List<Buff> buffs { get; set; }
        private List<Buff> debuffs { get; set; }

        public Item Drop
        {
            get
            {
                Random rng = new Random();
                return drops[rng.Next(0, drops.Count)];
            }
        }
    }
}
