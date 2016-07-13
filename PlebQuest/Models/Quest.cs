using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlebQuest
{
    public class Quest
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Name { get;  set; }
        [JsonProperty]
        public string Description { get; private set; }

        [JsonProperty]
        public int ExpReward { get; private set; }
        [JsonProperty]
        public int GoldReward { get; private set; }

        [JsonProperty]
        public Region Region { get; private set; }

        //default constructor
        public Quest()
        { }
    }
}
