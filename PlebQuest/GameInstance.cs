using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    public abstract class GameInstance
    {
        protected readonly Random Random = new();

        public GameData Data { get; } = new();

        public abstract GameContext Context { get; }

        public GameInstance()
        {
            DefaultContent.Register(Data);
        }

        protected IItemTemplate GetRandomItemTemplate()
        {
            return Data.ItemTemplates[Random.Next() % Data.ItemTemplates.Count];
        }

        public Item GenerateItem(GameContext context)
        {
            return GetRandomItemTemplate().Create(context);
        }
    }
}
