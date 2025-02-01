using consumindoApi_terceiros.Dtos;
using consumindoApi_terceiros.Models;

namespace consumindoApi_terceiros.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGeneric<Endereco>> GetEnderecoPorCep(string cep);
        Task<ResponseGeneric<List<Banco>>> GetAllBancos();
        Task<ResponseGeneric<Banco>> GetBancoCodigo(string codigo);
    }
}