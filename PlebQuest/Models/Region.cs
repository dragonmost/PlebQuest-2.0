using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlebQuest
{
    class Region
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Name { get; private set; }
        [JsonProperty]
        public string Description { get; private set; }

        [JsonProperty]
        public List<Quest> AvailableQuests { get; private set; }
        [JsonProperty]
        public List<Item> SoldItems { get; private set; }
        [JsonProperty]
        public List<Mob> AvailableMobs { get; private set; }

        //default constructor
        public Region(string ID,string Name,string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.AvailableQuests = new List<Quest>();
            this.AvailableMobs = new List<Mob>();
            this.SoldItems = new List<Item>();
        }
    }
}
