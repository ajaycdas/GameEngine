using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameEngineAPI.Controllers
{
    [Authorize(Roles = "Player")]
    [ApiController]
    [Route("api/[controller]")]
    public class BoardGameController : ControllerBase
    {
        private readonly ILogger<BoardGameController> _logger;

        public BoardGameController(ILogger<BoardGameController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "CheckGameAccess")]
        public string Get()
        {
            return "Yay! you have access to the game.";
        }
    }
}