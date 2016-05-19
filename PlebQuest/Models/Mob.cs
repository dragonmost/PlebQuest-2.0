using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Mob
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public int Level { get; set; }
        public int BaseExp { get; set; }
        public int BaseGold { get; set; }

        public Stats Stats { get; set; }

        public List<Item> Drops { get; set; }

        public List<Buff> Buffs { get; set; }
        public List<Buff> Debuffs { get; set; }

        public Item Drop
        {
            get
            {
                Random rng = new Random();
                return Drops[rng.Next(0, Drops.Count)];
            }
        }
    }
}
