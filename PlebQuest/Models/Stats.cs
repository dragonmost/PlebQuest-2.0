using System;
using Newtonsoft.Json;

namespace PlebQuest
{
    public class Stats
    {
        [JsonProperty]
        private int ID;

        [JsonProperty]
        public int Strength { get; private set; }
        [JsonProperty]
        public int Constitution { get; private set; }
        [JsonProperty]
        public int Dexterity { get; private set; }
        [JsonProperty]
        public int Intellect { get; private set; }
        [JsonProperty]
        public int Wisdom { get; private set; }
        [JsonProperty]
        public int Charisma { get; private set; }
            
        public Stats(int str, int con, int dex, int intel, int wis, int cha)
        {
            this.Strength = str;
            this.Constitution = con;
            this.Dexterity = dex;
            this.Intellect = intel;
            this.Wisdom = wis;
            this.Charisma = cha;
        }

        public void Randomize()
        {
            Random rng = new Random();

            this.Strength = rng.Next(1, 20);
            this.Constitution = rng.Next(1, 20);
            this.Dexterity = rng.Next(1, 20);
            this.Intellect = rng.Next(1, 20);
            this.Wisdom = rng.Next(1, 20);
            this.Charisma = rng.Next(1, 20);
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

        //default constructor
        public Stats()
        { }
    }
}
