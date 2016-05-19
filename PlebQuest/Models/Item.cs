using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    class Item
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public int GoldValue { get; set; }
        public int Weight { get; set; }

        public Item(string name, int goldValue, int weight)
        {
            this.Name = name;
            this.GoldValue = goldValue;
            this.Weight = weight;
        }
    }
}
