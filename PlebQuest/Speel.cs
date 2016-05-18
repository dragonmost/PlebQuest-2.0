using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Speel
    {
        private int ID;

        public string Name { get; set; }

        public int RequiredLevel { get; set; }
        public Stats RequiredStats { get; set; }

        public int Damage;
        public int Heal;
        public Buff Buff;
        public Buff Debuff;
    }
}
