using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;

namespace PlebQuest
{
    class Pleb
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Name { get; private set; }
        [JsonProperty]
        public bool IsMale { get; private set; }
        [JsonProperty]
        public TimeSpan PlayedTime { get; private set; }
        [JsonProperty]
        public int MaxHP { get; private set; }
        [JsonProperty]
        public int CurrentHP { get; private set; }
        [JsonProperty]
        public int Level { get; private set; }
        [JsonProperty]
        private int currentExp;
        [JsonProperty]
        public int Gold { get; private set; }

        [JsonProperty]
        public Stats Stats { get; private set; }
        [JsonProperty]
        public List<Item> Inventory { get; private set; }
        [JsonProperty]
        public List<Speel> SpeelBook { get; private set; }

        [JsonProperty]
        public Equipment Equipment { get; private set; }

        [JsonProperty]
        public List<Buff> Buffs { get; private set; }

        [JsonProperty]
        public int Alignment { get; private set; }

        [JsonProperty]
        public bool IsCheater { get; private set; }

        [JsonProperty]
        public Region Region { get; private set; }

        public Action OnLevelUp;

        //New Character
        public Pleb(string name, bool isMale, Stats stats, bool isCheater = true)
        {
            this.Name = name;
            this.IsMale = isMale;
            this.PlayedTime = new TimeSpan();
            //calculate HP
            //currentHP
            this.Level = 1;
            this.currentExp = 0;
            this.Gold = 0;

            this.Stats = stats;
            this.Inventory = new List<Item>();
            this.SpeelBook = new List<Speel>();

            this.Equipment = new Equipment();

            this.Buffs = new List<Buff>();

            this.Alignment = 0;

            this.IsCheater = isCheater;
        }

        //Old Character
        public Pleb(string id, string name, bool isMale, TimeSpan playedTime, int level, int currentExp, int gold, Stats stats, List<Item> inventory, int alignment, bool isCheater, Region region)
        {
            this.ID = id;

            this.Name = name;
            this.IsMale = IsMale;
            this.PlayedTime = playedTime;
            //calculate HP
            //currentHP
            this.Level = level;
            this.currentExp = currentExp;
            this.Gold = gold;

            this.Stats = stats;
            this.Inventory = inventory;

            this.Alignment = alignment;

            this.IsCheater = isCheater;

            this.Region = region;
        }

        public static Pleb Create(MySqlDataReader data)
        {
            return new Pleb
            {
                ID = data.GetString("id"),
                Name = data.GetString("name"),
                IsMale = data.GetInt32("gender") == 1,
                PlayedTime = data.GetTimeSpan("age"),
                Level = data.GetInt32("level"),
                currentExp = data.GetInt32("current_exp"),
                Gold = data.GetInt32("gold"),
                Alignment = data.GetInt32("alignement"),
                IsCheater = data.GetInt32("is_cheater") == 1,
                CurrentHP = data.GetInt32("current_hp"),
                MaxHP = data.GetInt32("current_hp"),
                /*
                * TODO : doit faire le calcul pour max Hp
                */
                Region = new Region(data.GetString("region_id"), data.GetString("region_name"), data.GetString("region_description")),
                Inventory = new List<Item>(),
                SpeelBook = new List<Speel>(),
                Equipment = new Equipment(),
                Buffs = new List<Buff>(),
                Stats = new Stats(data.GetString("stats_id"), data.GetInt32("strength"), data.GetInt32("constitution"), data.GetInt32("dexterity"), data.GetInt32("intellect"), data.GetInt32("wisdom"), data.GetInt32("charisma"))
            };
        }

        public Stats stats
        {
            get
            {
                return this.Stats; //+ Job.Stats + Race.Stats //+ equipment stats;
            }
        }

        //exp getter setter are aweful
        public int CurrentExp
        {
            get
            {
                return this.currentExp;
            }

            set
            {
                if (value > 20 * Level * 60)
                {
                    this.currentExp = 0;
                    this.Level++;

                    OnLevelUp?.Invoke();
                }
                else
                    this.currentExp = value;
            }
        }

        public void EarnExp(int expAmount)
        {
            CurrentExp += expAmount;
        }

        public void EarnAlignment(int pts)
        {
            this.Alignment += pts;

            if (Alignment > 100)
                this.Alignment = 100;
            else if (Alignment < -100)
                this.Alignment = -100;
        }

        public void Cheater()
        {
            this.IsCheater = true;
        }

        //default constructor
        public Pleb()
        { }
    }
}
