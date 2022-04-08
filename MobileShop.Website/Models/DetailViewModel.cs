using MobileShop.Domain;

namespace MobileShop.Website.Models
{
    public class DetailViewModel
    {
        public Product Product { get; set; }
        public List<ImageModel> Images { get; set; }
    }
}
