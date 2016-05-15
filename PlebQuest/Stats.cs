using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    [Serializable]
    class Stats
    {
        private int ID;

        public int Strength { get; private set; }
        public int Constitution { get; private set; }
        public int Dexterity { get; private set; }
        public int Intellect { get; private set; }
        public int Wisdom { get; private set; }
        public int Charisma { get; private set; }

        public Stats()
        {
            Random rng = new Random();
            
            this.Strength = rng.Next(1, 20);
            this.Constitution = rng.Next(1, 20);
            this.Dexterity = rng.Next(1, 20);
            this.Intellect = rng.Next(1, 20);
            this.Wisdom = rng.Next(1, 20);
            this.Charisma = rng.Next(1, 20);
        }

        public Stats(int str, int con, int dex, int intel, int wis, int cha)
        {
            this.Strength = str;
            this.Constitution = con;
            this.Dexterity = dex;
            this.Intellect = intel;
            this.Wisdom = wis;
            this.Charisma = cha;
        }
        
        public void Perfect()
        {
            this.Strength = 20;
            this.Constitution = 20;
            this.Dexterity = 20;
            this.Intellect = 20;
            this.Wisdom = 20;
            this.Charisma = 20;
        }        

        public static Stats operator + (Stats first, Stats second)
        {
            return new Stats(
                first.Strength + second.Strength,
                first.Constitution + second.Constitution,
                first.Dexterity + second.Dexterity,
                first.Intellect + second.Intellect,
                first.Wisdom + second.Wisdom,
                first.Charisma + second.Charisma);
        }
    }
}
