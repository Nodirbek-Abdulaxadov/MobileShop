using System.ComponentModel.DataAnnotations;

namespace MobileShop.Domain
{
    public class Connection
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public string StandardsSupport { get; set; }
        public string Interfaces { get; set; }
    }
}