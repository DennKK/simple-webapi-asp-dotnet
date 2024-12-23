using Microsoft.AspNetCore.Mvc;
using webapp.Api.Dto.platform;
using webapp.Api.Service.Platform;

namespace webapp.Api.Controller;

[ApiController]
[Route("api/v1/platforms")]
public class PlatformController(IPlatformService platformService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllPlatforms()
    {
        return Ok(platformService.GetAllPlatforms());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetPlatform([FromRoute] int id)
    {
        return Ok(platformService.GetPlatform(id));
    }

    [HttpPost]
    public IActionResult CreatePlatform([FromBody] CreatePlatformDto cretePlatformDto)
    {
        return Ok(platformService.CreatePlatform(cretePlatformDto));
    }
}
