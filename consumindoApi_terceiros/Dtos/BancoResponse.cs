using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consumindoApi_terceiros.Dtos
{
    public class BancoResponse
    {
        public string? Ispb { get; set; }
        public string? NomeAbreviado{ get; set; }
        public string? NomeCompleto { get; set; }
    }
}