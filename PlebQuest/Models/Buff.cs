using Newtonsoft.Json;

namespace PlebQuest
{
    class Buff
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

        [JsonProperty]
        public int ManaChange { get; private set; }

        public Buff(string id, string name, int nbTurn, Stats statChange, int hPChange, int manaChange)
        {
            this.ID = id;
            this.Name = name;
            this.NbTurn = nbTurn;
            this.StatChange = statChange;
            this.HPChange = hPChange;
            this.ManaChange = manaChange;

        }

        //default constructor
        public Buff()
        { }
    }
}
