using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            Category category = _dbContext.Categories
            .FirstOrDefault();
            CategoryViewModel vm = new CategoryViewModel();
            vm.Category = category;
            vm.Products = _dbContext.Products.ToList();
            
            return View(vm);
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Index(ProductCategory elem)
        {
            Category category = _dbContext.Categories
                .Include(pc=>pc.ProductCategory)
                .ThenInclude(p=>p.Product)
                .FirstOrDefault();

            CategoryViewModel vm = new CategoryViewModel();
            vm.Category = category;
            vm.Products = _dbContext.Products.ToList();
            
            if(!ModelState.IsValid) 
                return View(vm);

            if(_dbContext.ProductCategory.Any(p => p.ProductId == elem.ProductId && p.CategoryId == elem.CategoryId)) 
                return View(vm);

            _dbContext.ProductCategory.Add(elem);
            _dbContext.SaveChanges();

            return View(vm);
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
