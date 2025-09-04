using FilmInventory.Business.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FilmInventory.Controller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilmController : ControllerBase
{
    public IActionResult GetAll()
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult AddFilm([FromBody] Film film)
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateFilm([FromBody] Film film)
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeleteFilm(int filmId)
    {
        return Ok();
    }
}