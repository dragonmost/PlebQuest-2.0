﻿using Newtonsoft.Json;

namespace PlebQuest
{
    class Buff
    {
        [JsonProperty]
        private int ID;

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
