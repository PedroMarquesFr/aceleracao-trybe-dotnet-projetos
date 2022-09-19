using Microsoft.AspNetCore.Mvc;

namespace DevicesFactory.Controllers
{
    [ApiController]
    [Route("devices-factory")]
    public class DevicesFactoryController : ControllerBase
    {
        [HttpGet]
        public void RunFactory()
        {
            return;
        }
    }
}
