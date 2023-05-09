using Microsoft.AspNetCore.Mvc;

namespace BikeService.Controllers;

[ApiController]
[Route("LandingPage")]
public class LandingPageController : ControllerBase
{
    [HttpGet]
    public IActionResult Welcome()
    {
        Console.WriteLine("message accessed");
        return Ok("Welcome to BikeService!");
    }
}