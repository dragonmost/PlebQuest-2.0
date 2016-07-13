using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace PlebQuest
{
    public class Race
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Name { get; private set; }
        [JsonProperty]
        public string Description { get; private set; }

        [JsonProperty]
        public Stats stats { get; private set; }

        public static Race Create(MySqlDataReader data)
        {
            return new Race
            {
                ID = data.GetString("id"),
                Name = data.GetString("name"),
                Description = data.GetString("description"),
                stats = null
            };
        }

        //default constructor
        public Race()
        { }
    }
}
