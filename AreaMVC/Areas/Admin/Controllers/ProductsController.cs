using AreaMVC.Areas.Admin.Data.Interface;
using AreaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;

namespace AreaMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var products = _productService.GetProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (product != null)
            {
                TempData["Success"] = _productService.AddProduct(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}