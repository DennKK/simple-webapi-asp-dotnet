using Microsoft.AspNetCore.Mvc;
using webapp.Api.Dto.Platform;
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
    public IActionResult CreatePlatform([FromBody] CreatePlatformDto createPlatformDto)
    {
        return Ok(platformService.CreatePlatform(createPlatformDto));
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdatePlatform([FromRoute] int id, [FromBody] UpdatePlatformDto updatePlatformDto)
    {
        return Ok(platformService.UpdatePlatform(id, updatePlatformDto));
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeletePlatform([FromRoute] int id)
    {
        platformService.DeletePlatform(id);
        return NoContent();
    }
}
