using Newtonsoft.Json;

namespace PlebQuest
{
    public class Buff
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Name { get; private set; }

        [JsonProperty]
        public int NbTurn { get; private set; }

        [JsonProperty]
        public Stats StatChange { get; private set; }
        [JsonProperty]
        public int HPChange { get; private set; }

        //default constructor
        public Buff()
        { }
    }
}
