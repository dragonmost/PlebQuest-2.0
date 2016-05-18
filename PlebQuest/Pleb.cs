using System;
using System.Collections.Generic;

namespace PlebQuest
{
    class Pleb
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public bool Male { get;  set; }
        public TimeSpan PlayedTime { get; set; }
        public int MaxHP { get;  set; }
        public int currentHP { get; set; }
        public int Level { get; set; }
        public int currentExp { get; set; }
        public int Gold { get; set; }

        public Stats stats { private get; set; }
        public List<Item> Inventory { get; set; }
        public List<Speel> SpeelBook { get; set; }

        public Equipment Equipment { get; set; }

        public List<Buff> Buffs { get; set; }
        public List<Buff> Debuffs { get; set; }

        public int alignment { get; set; }

        public bool isCheater { get; set; }

        public Pleb(int id, string name, bool male, Stats stats, bool isCheater = true)
        {
            this.ID = id;

            this.Name = name;
            this.Male = male;
            this.PlayedTime = new TimeSpan();
            //calculate HP
            //currentHP
            this.Level = 1;
            this.currentExp = 0;
            this.Gold = 0;

            this.stats = stats;
            this.Inventory = new List<Item>();
            this.SpeelBook = new List<Speel>();

            this.Equipment = new Equipment();

            this.Buffs = new List<Buff>();
            this.Debuffs = new List<Buff>();

            this.alignment = 0;

            this.isCheater = isCheater;
        }

        public Pleb(int id, string name, bool male, TimeSpan playedTime, int level, int currentExp, int gold, Stats stats, List<Item> inventory, int alignment, bool isCheater)
        {
            this.ID = id;

            this.Name = name;
            this.Male = male;
            this.PlayedTime = playedTime;
            //calculate HP
            //currentHP
            this.Level = level;
            this.currentExp = currentExp;
            this.Gold = gold;

            this.stats = stats;
            this.Inventory = inventory;            
            
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
                if (value > 20 * Level * 60)
                {
                    this.currentExp = 0;
                    this.Level++;
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

        //default constructor
        public Pleb()
        { }
    }
}
