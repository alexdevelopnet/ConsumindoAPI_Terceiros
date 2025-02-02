using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using consumindoApi_terceiros.Dtos;
using consumindoApi_terceiros.Interfaces;

namespace consumindoApi_terceiros.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public Task<ResponseGeneric<EnderecoResponse>> BuscarEndereco(string cep)
        {
            throw new NotImplementedException();
        }


        public async Task<ResponseGeneric<EnderecoResponse>> BuscarEnderecoCep(string cep)
        {
            var endereco = await _brasilApi.GetEnderecoPorCep(cep);
            return _mapper.Map<ResponseGeneric<EnderecoResponse>>(endereco);
        }
    }
}