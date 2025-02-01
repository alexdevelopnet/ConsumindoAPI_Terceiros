using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace consumindoApi_terceiros.Dtos
{
    public class EnderecoResponse
    {
         
        public string? Cep;        
        public string? Estado;
        
        public string? Cidade;
        
        public string? REgiao;

        
        public string? Rua;

        [JsonIgnore]
        public string? Servico;
    }
}