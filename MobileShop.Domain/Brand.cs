using System.ComponentModel.DataAnnotations;

namespace MobileShop.Domain;

public class Brand
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
}

