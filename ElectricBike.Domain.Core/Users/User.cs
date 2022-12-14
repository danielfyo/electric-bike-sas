using System.ComponentModel.DataAnnotations;
using ElectricBike.Domain.Core.Base;
using ElectricBike.Domain.Core.Persons;

namespace ElectricBike.Domain.Core.Users;

public class User : EntityBase
{
    [Required]
    [MaxLength(20)]
    public string Username { get; set; } = default!;
    
    [Required]
    [MaxLength(8)]
    public string Password { get; set; } = default!;
    
    [Required]
    public Guid PersonId { get; set; } = default!;

    public virtual Person Person { get; set; } = default!;
}