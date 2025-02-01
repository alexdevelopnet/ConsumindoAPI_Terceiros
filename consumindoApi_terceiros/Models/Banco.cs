 
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace consumindoApi_terceiros.Models
{
    public class Banco
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);

        [JsonPropertyName("ispb")]
        public string? Ispb;

        [JsonPropertyName("name")]
        public string? NomeAbreviado;

        [JsonPropertyName("code")]
        public int Codigo;

        [JsonPropertyName("fullName")]
        public string? NomeCompleto;


    }
}