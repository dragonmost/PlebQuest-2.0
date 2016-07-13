using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace PlebQuest
{
    public class Classe
    {
        [JsonProperty]
        private string ID;

        [JsonProperty]
        public string Name { get; private set; }
        [JsonProperty]
        public string Description { get; private set; }

        [JsonProperty]
        public Stats Stats { get; private set; }

        [JsonProperty]
        public List<Speel> UsableSpeels { get; private set; }

        public static Classe Create(MySqlDataReader data)
        {
            return new Classe
            {
                ID = data.GetString("id"),
                Name = data.GetString("name"),
                Description = data.GetString("description"),
                Stats = null,
                UsableSpeels = null
            };
        }

        //default constructor
        public Classe()
        { }
    }
}
