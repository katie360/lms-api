using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/students")]
    [ApiController]
    public class StudentsV2Controller : Controller
    {
        [HttpGet]
        public IActionResult GetV2()
        {
            return Ok(new { Version = "v2.0", Message = "Students API - Version 2.0" });
        }
    }
}
