﻿using Microsoft.EntityFrameworkCore;
using MobileShop.Data;
using MobileShop.Domain;
using MobileShop.Service.Interfaces;

namespace MobileShop.Service.Repositories
{
    public class ProductRepository : IProductInterface
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Product AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(Guid id)
        {
            Product product = _dbContext.Products.FirstOrDefault(b => b.Id == id);
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public Product GetProduct(Guid id) =>
            _dbContext.Products.FirstOrDefault(b => b.Id == id);

        public List<Product> GetProducts() =>
            _dbContext.Products
            .Include(p => p.MainCharacters)
            .Include(p => p.ScreenCharacters)
            .Include(p => p.MultimediaFeatures)
            .Include(p => p.Connection)
            .Include(p => p.MemoryAndProcessor)
            .Include(p => p.Additionally)
            .ToList();

        public Product GetProductWithContents(Guid id) =>
            _dbContext.Products
            .Include(p => p.MainCharacters)
            .Include(p => p.ScreenCharacters)
            .Include(p => p.MultimediaFeatures)
            .Include(p => p.Connection)
            .Include(p => p.MemoryAndProcessor)
            .Include(p => p.Additionally)
            .FirstOrDefault(p => p.Id == id);

        public Product UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return product;
        }
    }
}
