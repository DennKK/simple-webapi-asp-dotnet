using System.ComponentModel.DataAnnotations;

namespace webapp.Api.Dto.Platform;

public record UpdatePlatformDto(
    [MaxLength(32)] string Name,
    [MaxLength(512)] string Description
);
