
using consumindoApi_terceiros.Dtos;

namespace consumindoApi_terceiros.Interfaces
{
    public interface IEnderecoService
    {
          Task<ResponseGeneric<EnderecoResponse>> BuscarEndereco(string cep);
    }
}