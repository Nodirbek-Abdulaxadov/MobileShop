using MobileShop.Domain;

namespace MobileShop.Website.Models
{
    public class IndexViewModel
    {
        public List<Product> Products { get; set; }
        public List<ImageModel> Images { get; set; }
    }
}
