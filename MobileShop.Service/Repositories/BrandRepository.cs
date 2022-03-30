using MobileShop.Data;
using MobileShop.Domain;
using MobileShop.Service.Interfaces;

namespace MobileShop.Service.Repositories
{
    public class BrandRepository : IBrandInterface
    {
        private readonly ApplicationDbContext _dbContext;

        public BrandRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Brand AddBrand(Brand brand)
        {
            _dbContext.Brands.Add(brand);
            _dbContext.SaveChanges();
            return brand;
        }

        public void DeleteBrand(Guid id)
        {
            Brand brand = _dbContext.Brands.FirstOrDefault(b => b.Id == id);
            _dbContext.Brands.Remove(brand);
            _dbContext.SaveChanges();
        }

        public Brand GetBrand(Guid id) =>
            _dbContext.Brands.FirstOrDefault(b => b.Id == id);

        public List<Brand> GetBrands() =>
            _dbContext.Brands.ToList();

        public Brand UpdateBrand(Brand brand)
        {
            _dbContext.Brands.Update(brand);
            _dbContext.SaveChanges();
            return brand;
        }
    }
}
