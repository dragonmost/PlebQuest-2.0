using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Speel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int RequiredLevel { get; set; }
        public Stats RequiredStats { get; set; }

        public int Damage { get; set; }
        public int Heal { get; set; }
        public Buff Buff { get; set; }
        public Buff Debuff { get; set; }
    }
}
