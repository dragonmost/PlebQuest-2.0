using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Pleb
    {
        public string Name { get; private set; }
        private int level { get; set; }
        private uint currentExp;

        private int alignment { get; set; }

        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intellect { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public Pleb()
        {
        }

        public uint CurrentExp
        {
            get
            {
                return this.currentExp;
            }

            set
            {
                if (value > 20 * level * 60)
                {
                    this.currentExp = 100;
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
