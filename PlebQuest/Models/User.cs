using Newtonsoft.Json;
using PlebQuest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebServer.Models
{
    class User
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Username { get; private set; }
        [JsonProperty]
        public string Password { get; private set; }
        [JsonProperty]
        public Pleb pleb { get; private set; }
        
    }
}
