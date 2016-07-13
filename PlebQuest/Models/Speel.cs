using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlebQuest
{
    class Speel
    {
        [JsonProperty]
        public string ID { get; private set; }

        [JsonProperty]
        public string Name { get; private set; }

        [JsonProperty]
        public int RequiredLevel { get; private set; }

        [JsonProperty]
        public Stats RequiredStats { get; private set; }

        [JsonProperty]
        public int Damage { get; private set; }
        [JsonProperty]
        public int Heal { get; private set; }
        [JsonProperty]
        public Buff Buff { get; private set; }
        [JsonProperty]
        public Buff Debuff { get; private set; }

        public Speel(string id, string name, int requiredLevel,Stats requiredStats,int damage,int heal, Buff buff, Buff debuff)
        {
            this.ID = id;
            this.Name = name;
            this.RequiredLevel = requiredLevel;
            this.RequiredStats = requiredStats;
            this.Damage = damage;
            this.Heal = heal;
            this.Buff = buff;
            this.Debuff = debuff;
        }

        //default constructor
        public Speel()
        { }
    }
}
