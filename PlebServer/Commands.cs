using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebServer
{
    public static class Commands
    {
        public const string ModalMessage = "ModalMessage";
        public const string CreateUser = "CreateUser";
        public const string PlayerConnection = "PlayerConnection";
        public const string ConnectionAccepted = "ConnectionAccepted";
        public const string ConnectionRefused = "ConnectionRefused";
        public const string SendCharacter = "SendCharacter";
        public const string UserCreationResponse = "UserCreationResponse";

        //Response
        public const string UserNotExist = "-1";
        public const string UserHasNoPleb = "0"; 
    }
}
