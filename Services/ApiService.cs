using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using aec_mvc_entity_framework.Models;
using Newtonsoft.Json;

namespace aec_mvc_entity_framework.Services
{
    public class ApiService
    {
      public static async Task<List<ApiCandidato>> GetApiCandidatos()
      {
          HttpClient http = new HttpClient();

          var response = await http.GetAsync($"{Program.ApiHost}api/Candidatos");
          if(response.IsSuccessStatusCode)
          {
              var resultado = response.Content.ReadAsStringAsync().Result;
              var candidatos = JsonConvert.DeserializeObject<List<ApiCandidato>>(resultado);
              return candidatos;
          }
          return new List<ApiCandidato>();
      }
    }
}