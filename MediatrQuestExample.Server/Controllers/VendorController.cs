using Microsoft.AspNetCore.Mvc;

namespace MediatrQuestExample.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class VendorController
    {
        private readonly ILogger<VendorController> _logger;

        public VendorController(ILogger<VendorController> logger)
        {
            _logger = logger;
        }
    }
}
