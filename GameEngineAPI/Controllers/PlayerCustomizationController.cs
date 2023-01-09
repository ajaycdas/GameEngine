using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameEngineAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerCustomizationController : ControllerBase
    {
        private readonly ILogger<PlayerCustomizationController> _logger;

        public PlayerCustomizationController(ILogger<PlayerCustomizationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "CheckCustomizationAccess")]
        public string Get()
        {
            return "Yay! you have access to customize players.";
        }
    }
}