using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Equipment
    {
        private int ID;

        public Head Head { get; private set; }
        public Chest Chest { get; private set; }
        public Pants Pants { get; private set; }
        public Boots Boots { get; private set; }
        public Weapon Weapon { get; private set; }
    }
}
