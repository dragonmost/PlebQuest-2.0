using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    [Serializable]
    class Pleb:ISerializable
    {
        public int ID { get; private set; }

        public string Name { get; private set; }
        public bool Male { get; private set; }
        private TimeSpan playedTime { get; set; }
        public int MaxHP { get; private set; }
        public int CurrentHP { get; private set; }
        private int level { get; set; }
        private int currentExp { get; set; }
        public int Gold { get; private set; }

        private Stats stats { get; set; }
        private List<Item> inventory { get; set; }
        private List<Speel> SpeelBook { get; set; }

        private Equipment equipment { get; set; }

        private List<Buff> buffs { get; set; }
        private List<Buff> debuffs { get; set; }

        private int alignment { get; set; }

        private bool isCheater;

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
                return Stats; //+ Job.Stats + Race.Stats //+ equipment stats;
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

        public Pleb(SerializationInfo info, StreamingContext ctxt)
        {
            ID = (int)info.GetValue("ID", typeof(int));

            Name = (string)info.GetValue("Name", typeof(string));
            Male = (bool)info.GetValue("Male", typeof(bool));
            //HP
            level = (int)info.GetValue("level", typeof(int));
            currentExp = (int)info.GetValue("currentExp", typeof(int));
            Gold = (int)info.GetValue("Gold", typeof(int));
            playedTime = (TimeSpan)info.GetValue("playedTime", typeof(TimeSpan));

            //stats = (Stats)info.GetValue("stats", typeof(Stats));
            //inventory = (List<Item>)info.GetValue("inventory", typeof(List<Item>));
            //spells

            //equipment

            //buff
            //debuff

            alignment = (int)info.GetValue("alignment", typeof(int));
            isCheater = (bool)info.GetValue("isCheater", typeof(bool));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", ID);

            info.AddValue("Name", Name);
            info.AddValue("Male", Male);
            //currentHP
            info.AddValue("level", level);
            info.AddValue("currentExp", currentExp);
            info.AddValue("Gold", Gold);
            info.AddValue("playedTime", playedTime);

            //info.AddValue("stats", stats);
            //info.AddValue("inventory", inventory);
            //spells

            //equipment

            //buff
            //debuff

            info.AddValue("alignment", alignment);
            info.AddValue("isCheater", isCheater);
        }
    }
}
