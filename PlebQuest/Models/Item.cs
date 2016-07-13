using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlebQuest
{
    class Item
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Name { get; private set; }
        [JsonProperty]
        public int GoldValue { get; private set; }
        [JsonProperty]
        public int Weight { get; private set; }

        public Item(string id, string name, int goldValue, int weight)
        {
            this.ID = id;
            this.Name = name;
            this.GoldValue = goldValue;
            this.Weight = weight;
        }

        //default constructor
        public Item()
        { }
    }
}
