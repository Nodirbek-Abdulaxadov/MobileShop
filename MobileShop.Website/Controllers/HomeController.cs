using Microsoft.AspNetCore.Mvc;
using MobileShop.Service.Interfaces;
using MobileShop.Website.Models;
using MobileShop.Website.Services;
using System.Diagnostics;

namespace MobileShop.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductInterface _productInterface;
        private readonly IFileInterface _fileInterface;

        public HomeController(ILogger<HomeController> logger,
                              IProductInterface productInterface,
                              IFileInterface fileInterface)
        {
            _logger = logger;
            _productInterface = productInterface;
            _fileInterface = fileInterface;
        }

        public IActionResult Index()
        {
            var listOfProducts = _productInterface.GetProducts().Take(6).ToList();
            var listOfImages = _fileInterface.GetImages();
            IndexViewModel viewModel = new IndexViewModel()
            {
                Products = listOfProducts,
                Images = listOfImages
            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Card(Guid id)
        {
            var pr = _productInterface.GetProductWithContents(id);
            var listOfImages = _fileInterface.GetImages();
            IndexViewModel viewModel = new IndexViewModel()
            {
                Product = pr,
                Images = listOfImages
            };
            return View(viewModel);
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Details(Guid id)
        {
            DetailViewModel viewModel = new DetailViewModel()
            {
                Product = _productInterface.GetProductWithContents(id),
                Images = _fileInterface.GetImages(id)
            };

            return View(viewModel);
        }

        public IActionResult Products()
        {
            var listOfProducts = _productInterface.GetProducts().ToList();
            var listOfImages = _fileInterface.GetImages();
            IndexViewModel viewModel = new IndexViewModel()
            {
                Products = listOfProducts,
                Images = listOfImages
            };

            return View(viewModel);
        }

        public IActionResult WhyUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}