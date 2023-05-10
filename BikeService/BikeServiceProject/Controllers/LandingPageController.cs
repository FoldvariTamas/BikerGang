using Microsoft.AspNetCore.Mvc;

namespace BikeServiceProject.Controllers;

[ApiController]
[Route("LandingPage")]
public class LandingPageController : ControllerBase
{
    [HttpGet]
    public IActionResult Welcome()
    {
        Console.WriteLine("message accessed");
        return Ok("Welcome to BikeServiceProject!");
    }
}