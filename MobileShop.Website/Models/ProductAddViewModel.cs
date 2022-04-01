using MobileShop.Domain;

namespace MobileShop.Website.Models
{
    public class ProductAddViewModel
    {
        public Product Product { get; set; }
        public List<Brand> Brands { get; set; }
    }
}
