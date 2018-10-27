using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Products_and_Categories.Models;
using Products_and_Categories.Persistence;

namespace Products_and_Categories.Controllers
{
    public class HomeController : Controller
    {
        private ProductsAndCategoriesDbContext _dbContext;
        public HomeController(ProductsAndCategoriesDbContext context){
            _dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/products")]
        public IActionResult CreateProduct()
        {
            CreateProductViewModel vm = new CreateProductViewModel();
            vm.Products = _dbContext.Products;
            return View(vm);
        }

        [HttpPost]
        [Route("/products")]
        public IActionResult CreateProduct(CreateProductViewModel vm)
        {
            if(!ModelState.IsValid) 
                return View();

            _dbContext.Add(vm.Product);
            _dbContext.SaveChanges();

            return View();
        }

        [HttpGet]
        [Route("/categories")]
        public IActionResult CreateCategory()
        {
            CreateCategoryViewModel vm = new CreateCategoryViewModel();
            vm.Categories = _dbContext.Categories;
            return View(vm);
        }

        [HttpPost]
        [Route("/categories")]
        public IActionResult CreateCategory(CreateCategoryViewModel vm)
        {
            if(!ModelState.IsValid) 
                return View();

            _dbContext.Add(vm.Category);
            _dbContext.SaveChanges();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
