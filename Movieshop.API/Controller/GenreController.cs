using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Movieshop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        [Route("list")]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
