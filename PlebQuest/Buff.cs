using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Buff
    {
        private int ID;

        public string Name { get; private set; }

        public int NbTurn { get; private set; }

        public Stats StatChange { get; private set; }
        public int HPChange { get; private set; }
    }
}
