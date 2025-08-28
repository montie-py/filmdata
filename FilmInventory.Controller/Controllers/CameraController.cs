using FilmInventory.Business.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FilmInventory.Controller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CameraController : ControllerBase
{
    public IActionResult GetAll()
    {
        return Ok();
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult Post([FromBody] Camera camera)
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Camera camera)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Ok();
    }
}