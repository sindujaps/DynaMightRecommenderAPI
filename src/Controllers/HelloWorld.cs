using Microsoft.AspNetCore.Mvc;

namespace SkillsRecommenderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult HelloWorld()
        {
            return Ok("Hello, World!");
        }
    }
}