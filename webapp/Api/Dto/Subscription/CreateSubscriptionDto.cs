using System.ComponentModel.DataAnnotations;

namespace webapp.Api.Dto.Subscription;

public record CreateSubscriptionDto(
    [Required] int PlatformId,
    [Required] [MaxLength(32)] string Name,
    decimal Price,
    [Required] DateTime StartDate,
    DateTime? EndDate,
    bool IsActive = true
);
