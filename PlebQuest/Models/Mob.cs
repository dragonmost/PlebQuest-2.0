using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlebQuest
{
    public class Mob
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Name { get; private set; }
        [JsonProperty]
        public int Level { get; private set; }
        [JsonProperty]
        public int BaseExp { get; private set; }
        [JsonProperty]
        public int BaseGold { get; private set; }

        [JsonProperty]
        public Stats Stats { get; private set; }

        [JsonProperty]
        private List<Item> drops;

        [JsonProperty]
        private List<Buff> buffs { get; set; }
        [JsonProperty]
        private List<Buff> debuffs { get; set; }

        public int HP { get; set; }

        public Item Drop
        {
            get
            {
                Random rng = new Random();
                return drops[rng.Next(0, drops.Count)];
            }
        }

        //default constructor
        public Mob()
        { }
    }
}
