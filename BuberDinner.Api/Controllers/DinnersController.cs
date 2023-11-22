using BuberDinner.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api;

[Route("[controller]")]
public class DinnersController : ApiController
{
    [HttpGet]
    public async Task<IActionResult> ListDinners()
    {
        return Ok(Array.Empty<string>());
    }
}
