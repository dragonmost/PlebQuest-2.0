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

        //default constructor
        public Speel()
        { }
    }
}
