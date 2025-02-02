using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace consumindoApi_terceiros.Dtos
{
    public class EnderecoResponse
    {

        public string? Cep { get; set; }
        public string? Estado { get; set; }

        public string? Cidade { get; set; }

        public string? REgiao { get; set; }


        public string? Rua { get; set; }

        [JsonIgnore]
        public string? Servico { get; set; }
    }
}