
using AutoMapper;
using consumindoApi_terceiros.Dtos;
using consumindoApi_terceiros.Models;

namespace consumindoApi_terceiros.Mapping
{
    public class EnderecoMapping: Profile
    {

        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<EnderecoResponse, Endereco>();
            CreateMap<Endereco, EnderecoResponse>();
        }
    }
}