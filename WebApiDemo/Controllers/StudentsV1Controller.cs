using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/students")]
    [ApiController]
    public class StudentsV1Controller : Controller
    {
        [HttpGet]
        public IActionResult GetV1()
        {
            return Ok(new { Version = "v1.0", Message = "Students API - Version 1.0" });
        }
    }
}
