
using System.Dynamic;
using System.Text.Json;
using consumindoApi_terceiros.Dtos;
using consumindoApi_terceiros.Interfaces;
using consumindoApi_terceiros.Models;

namespace consumindoApi_terceiros.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGeneric<Endereco>> GetEnderecoPorCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $@"{cep}");
            var response = new ResponseGeneric<Endereco>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<Endereco>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
                return response;
            }
        }
        public Task<ResponseGeneric<List<Banco>>> GetAllBancos()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGeneric<Banco>> GetBancoCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

    }
}