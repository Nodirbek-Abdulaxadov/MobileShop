using Microsoft.AspNetCore.Mvc;
using MobileShop.Domain;
using MobileShop.Service.Interfaces;
using MobileShop.Website.Models;

namespace MobileShop.Website.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBrandInterface _brandInterface;
        private readonly IProductInterface _productInterface;

        public AdminController(IBrandInterface brandInterface, IProductInterface productInterface)
        {
            _brandInterface = brandInterface;
            _productInterface = productInterface;
        }
        public IActionResult Index()
        {
            var listOfBrands = _brandInterface.GetBrands();
            return View(listOfBrands);
        }

        #region Product
        public IActionResult Products()
        {
            var listOfProducts = _productInterface.GetProducts();
            return View(listOfProducts);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            var listOfBrands = _brandInterface.GetBrands();
            ProductAddViewModel viewModel = new ProductAddViewModel()
            {
                Brands = listOfBrands
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductAddViewModel viewModel)
        {
            viewModel.Product.Id = Guid.NewGuid();

            _productInterface.AddProduct(viewModel.Product);

            return RedirectToAction("Products");
        }

        #endregion

        #region Brand
        [HttpGet]
        public IActionResult AddBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            brand.Id = Guid.NewGuid();
            _brandInterface.AddBrand(brand);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBrand(Guid id)
        {
            _brandInterface.DeleteBrand(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditBrand(Guid id)
        {
            Brand brand = _brandInterface.GetBrand(id);
            return View(brand);
        }
        [HttpPost]
        public IActionResult EditBrand(Brand brand)
        {
            _brandInterface.UpdateBrand(brand);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
