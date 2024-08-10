using MediatrQuestExample.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediatrQuestExample.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class QuestController : ControllerBase
    {
        private readonly ILogger<QuestController> _logger;
        private readonly IQuestService _questService;

        public QuestController(ILogger<QuestController> logger, IQuestService questService)
        {
            _logger = logger;
            _questService = questService;
        }

        [HttpGet]
        public IActionResult GetAllQuests()
        {
            return Ok(_questService.GetAllQuests());
        }
    }
}
