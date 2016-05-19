using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PlebQuest
{
    class Pleb
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Name { get; private set; }
        [JsonProperty]
        public bool Male { get; private set; }
        [JsonProperty]
        public TimeSpan playedTime { get; private set; }
        [JsonProperty]
        public int MaxHP { get; private set; }
        [JsonProperty]
        public int CurrentHP { get; private set; }
        [JsonProperty]
        public int level { get; private set; }
        [JsonProperty]
        public int currentExp { get; private set; }
        [JsonProperty]
        public int Gold { get; private set; }

        [JsonProperty]
        public Stats stats { get; private set; }
        [JsonProperty]
        public List<Item> inventory { get; private set; }
        [JsonProperty]
        public List<Speel> SpeelBook { get; private set; }

        [JsonProperty]
        public Equipment equipment { get; private set; }

        [JsonProperty]
        public List<Buff> buffs { get; private set; }

        [JsonProperty]
        public int alignment { get; private set; }

        [JsonProperty]
        public bool isCheater { get; private set; }

        //New Character
        public Pleb(string name, bool male, Stats stats, bool isCheater = true)
        {
            this.Name = name;
            this.Male = male;
            this.playedTime = new TimeSpan();
            //calculate HP
            //currentHP
            this.level = 1;
            this.currentExp = 0;
            this.Gold = 0;

            this.stats = stats;
            this.inventory = new List<Item>();
            this.SpeelBook = new List<Speel>();

            this.equipment = new Equipment();

            this.buffs = new List<Buff>();

            this.alignment = 0;

            this.isCheater = isCheater;
        }

        //Old Character
        public Pleb(string id, string name, bool male, TimeSpan playedTime, int level, int currentExp, int gold, Stats stats, List<Item> inventory, int alignment, bool isCheater)
        {
            this.ID = id;

            this.Name = name;
            this.Male = male;
            this.playedTime = playedTime;
            //calculate HP
            //currentHP
            this.level = level;
            this.currentExp = currentExp;
            this.Gold = gold;

            this.stats = stats;
            this.inventory = inventory;            
            
            this.alignment = alignment;

            this.isCheater = isCheater;
        }

        public Stats Stats
        {
            get
            {
                return this.stats; //+ Job.Stats + Race.Stats //+ equipment stats;
            }
        }

        public int CurrentExp
        {
            get
            {
                return this.currentExp;
            }

            set
            {
                if (value > 20 * level * 60)
                {
                    this.currentExp = 0;
                    this.level++;
                }
                else
                    this.currentExp = value;
            }
        }

        public int Alignment
        {
            get
            {
                return this.alignment;
            }

            set
            {
                if (value > 100)
                    this.alignment = 100;
                else if (value < -100)
                    this.alignment = -100;
                else
                    this.alignment = value;
            }
        }

        public void Cheater()
        {
            this.isCheater = true;
        }

        //default constructor
        public Pleb()
        { }
    }
}
