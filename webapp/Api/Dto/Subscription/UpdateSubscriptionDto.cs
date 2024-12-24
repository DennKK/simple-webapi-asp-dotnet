using System.ComponentModel.DataAnnotations;

namespace webapp.Api.Dto.Subscription;

public record UpdateSubscriptionDto(
    [Required] [MaxLength(32)] string Name,
    decimal Price,
    [Required] DateTime StartDate,
    DateTime? EndDate,
    bool IsActive = true
);
