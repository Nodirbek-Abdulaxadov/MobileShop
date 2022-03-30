using System.ComponentModel.DataAnnotations;

namespace MobileShop.Domain
{
    public class Product
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public MainCharacters MainCharacters { get; set; }
        public ScreenCharacters ScreenCharacters { get; set; }
        public MultimediaFeatures MultimediaFeatures { get; set; }
        public Connection Connection { get; set; }
        public MemoryAndProcessor MemoryAndProcessor { get; set; }
        public Additionally Additionally { get; set; }
        [Required]
        public List<ImageModel> Images { get; set; }
        [Required]
        public Guid BrandId { get; set; }
    }
}