using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    public class Client : GameInstance
    {
        public Character Character { get; } = new Character();

        public override GameContext Context => new GameContext(Character, Random);

        public Item GenerateItem()
        {
            return GenerateItem(Context);
        }
    }
}
