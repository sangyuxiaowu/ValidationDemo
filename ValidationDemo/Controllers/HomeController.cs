using Microsoft.AspNetCore.Mvc;

namespace ValidationDemo.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        public OrgRegInfo Index([FromBody] OrgRegInfo orgreginfo)
        {
            return orgreginfo;
        }
    }
}
