
using System.Net;
using consumindoApi_terceiros.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace consumindoApi_terceiros.Controller
{
    [ApiController]
    [Route("api/v1/controller")]
    public class EnderecoController : ControllerBase
    {
        private readonly ILogger<EnderecoController> _logger;
        private readonly IEnderecoService _service;

        public EnderecoController(ILogger<EnderecoController> logger, IEnderecoService service)
        {
            _logger = logger;
            _service = service;
        }


        [HttpGet("busca/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarEnderecoCep(string cep)
        {
            _logger.LogInformation("Iniciando busca para o CEP: {cep}", cep);

            var response = await _service.BuscarEndereco(cep);
            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                _logger.LogInformation("Busca realizada com sucesso. Dados Retorno: {dadosRetorno}", response.DadosRetorno);
                return Ok(response.DadosRetorno);
            }
            else
            {
                _logger.LogWarning("Erro na busca. Código HTTP: {codigoHttp}, Erro: {erroRetorno}", response.CodigoHttp, response.ErroRetorno);
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }


    }
}