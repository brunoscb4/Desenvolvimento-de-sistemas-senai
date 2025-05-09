using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using static System.Net.WebRequestMethods;

namespace JogosGratis.Programa
{
    internal class ApiService
    {
        private readonly string baseUrl = "https://www.freetogame.com/api/games?platform=pc";

        public async Task <List<ApiGame>> ObterJogosAsynk() 
        {

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(baseUrl);
                return JsonConvert.DeserializeObject<List<ApiGame>>(json);
            }
        
        }
    }
}
