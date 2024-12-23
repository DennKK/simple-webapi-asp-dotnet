﻿using System.ComponentModel.DataAnnotations;

namespace webapp.Api.Dto.Platform;

public record CreatePlatformDto(
    [MaxLength(32)] string Name,
    [MaxLength(512)] string Description
);
