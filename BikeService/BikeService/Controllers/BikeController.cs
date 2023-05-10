using BikeService.Service;
using Microsoft.AspNetCore.Mvc;

namespace BikeService.Controllers;

[ApiController]
[Route("[controller]")]
public class BikeController : ControllerBase
{
    private readonly IBikeService _bikeService;

    public BikeController(IBikeService bikeService)
    {
        _bikeService = bikeService;
    }

    [HttpGet("allBike")]
    public IActionResult GetAllBike()
    {
        return Ok(_bikeService.GetAllBikes());
    }
}