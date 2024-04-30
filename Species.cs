using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Star_Wars_API
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<AllSpecies>(myJsonResponse);
    public class Species
    {
        //establish attributes
        public string name { get; set; }
        public string classification { get; set; }
        public string designation { get; set; }
        public string average_height { get; set; }
        public string skin_colors { get; set; }
        public string hair_colors { get; set; }
        public string eye_colors { get; set; }
        public string average_lifespan { get; set; }
        public string homeworld { get; set; }
        public string language { get; set; }
        public List<string> people { get; set; }
        public List<string> films { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
    }

    public class AllSpecies
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Species> results { get; set; }
    }
}
