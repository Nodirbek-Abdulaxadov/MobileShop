using MobileShop.Domain;

namespace MobileShop.Website.Models
{
    public class ProductDetailsViewModel
    {
        public Product Product { get; set; }
        public List<ImageModel> Images { get; set; }
    }
}
