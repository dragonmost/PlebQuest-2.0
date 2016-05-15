using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Classe
    {
        private int ID;

        public string Name { get; private set; }
        public Stats Stats { get; private set; }

        public List<Speel> UsableSpeels { get; private set; }
    }
}
