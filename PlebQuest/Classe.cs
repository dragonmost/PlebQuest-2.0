using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Classe
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public Stats Stats { get; set; }

        public List<Speel> UsableSpeels { get; private set; }
    }
}
