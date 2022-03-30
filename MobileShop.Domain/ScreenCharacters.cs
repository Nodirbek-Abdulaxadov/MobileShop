using System.ComponentModel.DataAnnotations;

namespace MobileShop.Domain
{
    public class ScreenCharacters
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public string ScreenType { get; set; }
        public double Diagonal { get; set; }
        public string ImageSize { get; set; }
        public string AspectRatio { get; set; }
        public string ScreenHZ { get; set; }
    }
}