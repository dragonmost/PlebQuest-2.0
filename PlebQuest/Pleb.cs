using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Pleb
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        //gender ?
        //age?
        private int level { get; set; }
        private int currentExp;

        private Stats stats;

        private int alignment { get; set; }

        private bool isCheater;     

        public Pleb(int id, string name, Stats stats, bool isCheater)
        {
            this.ID = id;
            this.Name = name;
            this.stats = stats;

            this.level = 1;
            this.currentExp = 0;
            this.alignment = 0;

            this.isCheater = isCheater;
        }

        public Pleb(int id, string name, Stats stats, int level, int currentExp, int alignment, bool isCheater)
        {
            this.ID = id;
            this.Name = name;
            this.stats = stats;

            this.level = level;
            this.currentExp = currentExp;
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
    }
}
