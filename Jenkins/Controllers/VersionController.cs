using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jenkins.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        public VersionController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]

        public IActionResult GetVersion()
        {
            return Ok($"Api Version: {Configuration.GetSection("ApiVersion").Value}");
        }
    }
}
