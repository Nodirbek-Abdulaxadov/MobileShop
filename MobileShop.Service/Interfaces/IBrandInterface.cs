using MobileShop.Domain;

namespace MobileShop.Service.Interfaces
{
    public interface IBrandInterface
    {
        List<Brand> GetBrands();
        Brand GetBrand(Guid id);
        Brand AddBrand(Brand brand);
        Brand UpdateBrand(Brand brand);
        void DeleteBrand(Guid id);
    }
}
