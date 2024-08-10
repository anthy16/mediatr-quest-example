using Microsoft.AspNetCore.Mvc;

namespace MediatrQuestExample.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FightController
    {
        private readonly ILogger<FightController> _logger;

        public FightController(ILogger<FightController> logger)
        {
            _logger = logger;
        }
    }
}
