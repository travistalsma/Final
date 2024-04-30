using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_API
{
    public class Starships : JSONHelper
    {
        //establish attributes
        public string name { get; set; }

        static readonly HttpClient client = new HttpClient();

        // Inheritance method that allows us to select a starship at random for our random person, planet, and starship functionality. 
        override public async Task<Starships> GetStarships(string ID)
        {
            Starships myDeserializedClass = new Starships();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://swapi.py4e.com/api/starships/" + ID + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<Starships>(responseBody);
                //Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }
    }
}
