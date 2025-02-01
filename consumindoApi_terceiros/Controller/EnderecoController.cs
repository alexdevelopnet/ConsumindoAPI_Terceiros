 
using Microsoft.AspNetCore.Mvc;
 
namespace consumindoApi_terceiros.Controller
{
    [ApiController]
    [Route("[api/v1/controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly ILogger<EnderecoController> _logger;

        public EnderecoController(ILogger<EnderecoController> logger)
        {
            _logger = logger;
        }

         

        
    }
}