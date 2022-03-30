using MobileShop.Domain;

namespace MobileShop.Service.Interfaces
{
    public interface IProductInterface
    {
        List<Product> GetProducts();
        Product GetProduct(Guid id);
        Product AddProduct(Product product);
        Product UpdateProduct(Product product);
        void DeleteProduct(Guid id);
    }
}
