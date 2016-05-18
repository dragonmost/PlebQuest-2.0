using System;
using System.Collections.Generic;

namespace PlebQuest
{
    class Pleb
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public bool Male { get;  set; }
        public TimeSpan playedTime { get; set; }
        public int MaxHP { get;  set; }
        public int CurrentHP { get; set; }
        public int level { get; set; }
        public int currentExp { get; set; }
        public int Gold { get; set; }

        public Stats stats { get; set; }
        public List<Item> inventory { get; set; }
        public List<Speel> SpeelBook { get; set; }

        public Equipment equipment { get; set; }

        public List<Buff> buffs { get; set; }
        public List<Buff> debuffs { get; set; }

        public int alignment { get; set; }

        public bool isCheater { get; set; }

        public Pleb(int id, string name, bool male, Stats stats, bool isCheater = true)
        {
            this.ID = id;

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
            this.debuffs = new List<Buff>();

            this.alignment = 0;

            this.isCheater = isCheater;
        }

        public Pleb(int id, string name, bool male, TimeSpan playedtime, int level, int currentExp, int gold, Stats stats, List<Item> inventory, int alignment, bool isCheater)
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

        //default constructor
        public Pleb()
        { }
    }
}
