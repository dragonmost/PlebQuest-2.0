using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebServer
{
    public interface ICommands
    {
        Response PlayerConnection(GameClient gameClient, string[] data);

        Response UserCreation(GameClient client, string username, string pw);
    }
}
