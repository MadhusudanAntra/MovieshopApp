using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
namespace Movieshop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService genreService;
        public GenreController(IGenreService gen)
        {
            genreService = gen;
        }

        [Route("list")]
        public async Task<IActionResult> GetAll()
        {
            var data = await genreService.GetAllGenresAsync();
            if (data == null)
            {
                return NotFound("No Genre available");
            }
            return Ok(data);
        }

        [HttpPost]
        
        public async Task<IActionResult> Post(GenreModel model)
        {
            if (await genreService.InsertGenreAsync(model) >0)
                return Ok(model);
            return BadRequest();
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await genreService.DeleteGenreAsync(id) > 0)
                return Ok("Genre is deleted");
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(GenreModel m)
        {
            if (await genreService.UpdateGenreAsync(m) > 0)
                return Ok("Genre is updated");
            return NoContent();
        }
    }
}
