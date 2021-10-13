using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    public interface IItemTemplate
    {
        Item Create(GameContext context);
    }
}
