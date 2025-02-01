
using Microsoft.AspNetCore.Mvc;

namespace consumindoApi_terceiros.Controller
{
    [ApiController]
    [Route("[api/v1/controller]")]
    public class BancoController : ControllerBase
    {
        private readonly ILogger<BancoController> _logger;

        public BancoController(ILogger<BancoController> logger)
        {
            _logger = logger;
        }

    }
}