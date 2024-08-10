using Microsoft.AspNetCore.Mvc;

namespace MediatrQuestExample.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class QuestController
    {
        private readonly ILogger<QuestController> _logger;

        public QuestController(ILogger<QuestController> logger)
        {
            _logger = logger;
        }
    }
}
