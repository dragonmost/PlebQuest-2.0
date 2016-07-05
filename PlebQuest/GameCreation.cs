using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class GameCreation
    {
        public Stats Stats { get; private set; }

        private Race[] races;
        private Classe[] classes;

        public GameCreation()
        {
            Stats = new Stats();
            Stats.Randomize();
        }

        public void Randomize()
        {
            Stats.Randomize();
        }

        public int TotalStats
        {
            get
            {
                int total = 0;

                foreach (PropertyInfo property in Stats.GetType().GetProperties())
                {
                    total += (int)property.GetValue(Stats);
                }

                return total;
            }
        }

        public Race[] Races
        {
            get
            {
                if(this.races == null)
                    this.races = Client.Instance.GetDBOjects<Race>("races");

                return this.races;
                
            }
        }

        public Classe[] Classes
        {
            get
            {
                if (classes == null)
                    classes = Client.Instance.GetDBOjects<Classe>("Classes");

                return classes;
            }
        }

        public void MakePerfect()
        {
            Stats.Perfect();
        }
    }
}
