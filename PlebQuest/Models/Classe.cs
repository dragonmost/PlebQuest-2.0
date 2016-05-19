using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlebQuest
{
    class Classe
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Name { get; private set; }
        [JsonProperty]
        public Stats Stats { get; private set; }

        [JsonProperty]
        public List<Speel> UsableSpeels { get; private set; }

        //default constructor
        public Classe()
        { }
    }
}
