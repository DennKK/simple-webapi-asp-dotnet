using Microsoft.AspNetCore.Mvc;
using webapp.Api.Service.Platform;

namespace webapp.Api.Controller;

[ApiController]
[Route("api/v1/platforms")]
public class PlatformController(IPlatformService platformService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllPlatforms()
    {
        var platforms = platformService.GetAllPlatforms();
        return Ok(platforms);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetPlatform([FromRoute] int id)
    {
        var platform = platformService.GetPlatform(id);
        return Ok(platform);
    }
}
