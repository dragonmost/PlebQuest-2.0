using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    public class Weapon
    {
        private int ID;

        public string Name { get; private set; }
        public int Damage { get; private set; }
        public Stats Stats { get; private set; }

        public int RequiredLevel { get; private set; }
        public Stats RequiredStats { get; private set; }
    }
}
