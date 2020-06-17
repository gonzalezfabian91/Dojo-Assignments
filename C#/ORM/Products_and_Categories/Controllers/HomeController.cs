using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products_and_Categories.Models;

namespace Products_and_Categories.Controllers
{
    public class HomeController : Controller
    {
        private Products_and_CategoriesContext db;
        public HomeController(Products_and_CategoriesContext context)
        {
            db = context;
        }

        [HttpGet("/")]
        public IActionResult Products()
        {
            ViewBag.AllProducts = db.Product.ToList();
            return View("Products");
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.AllCategories = db.Categories.ToList();
            return View("Categories");
        }

        [HttpPost("product/create")]
        public IActionResult CreateProduct(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                db.Add(newProduct);
                db.SaveChanges();
                return RedirectToAction("Products", newProduct);
            }
            return View("Products");
        }

        [HttpPost("categories/create")]
        public IActionResult CreateCategory(Categories newCategory)
        {
            if (ModelState.IsValid)
            {
                db.Add(newCategory);
                db.SaveChanges();
                return RedirectToAction("Categories", newCategory);
            }
            return View("Categories");
        }

        [HttpGet("product/{productId}")]
        public IActionResult OneProduct(int productId)
        {
            var ProductwithCategories = db.Product
                .Include(p => p.Categories)
                .ThenInclude(a => a.Category)
                .FirstOrDefault(p => p.ProductId == productId);

            List<Categories> AllCategories = db.Categories
                .Include(c => c.Products)
                .ThenInclude(a => a.Product)
                .Where(c => c.Products.All(a => a.Product.ProductId != productId)).ToList();

            IEnumerable<Categories> relatedCategories = ProductwithCategories.Categories
                .Select(a => a.Category);

            List<Categories> UnrelatedCats = db.Categories
                .Except(relatedCategories)
                .ToList();

            OneProductViewModel oneproduct = new OneProductViewModel();
            oneproduct.Product = ProductwithCategories;
            oneproduct.AllCategoriesForProduct = AllCategories;

            return View("OneProduct", oneproduct);
        }

        [HttpGet("category/{categoryId}")]
        public IActionResult OneCategory(int categoryId)
        {
            var CategoryWithProducts = db.Categories
                .Include(c => c.Products)
                .ThenInclude(a => a.Product)
                .FirstOrDefault(c => c.CategoryId == categoryId);

            List<Product> AllProducts = db.Product
                .Include(p => p.Categories)
                .ThenInclude(a => a.Category)
                .Where(p => p.Categories.All(a => a.Category.CategoryId == categoryId)).ToList();

            IEnumerable<Product> relatedProducts = CategoryWithProducts.Products
                .Select(a => a.Product);

            List<Product> UnrelatedProduct = db.Product
                .Except(relatedProducts)
                .ToList();

            OneCategoryViewModel onecategory = new OneCategoryViewModel();
            onecategory.Category = CategoryWithProducts;
            onecategory.AllProductsForCategory = AllProducts;

            return View("OneCategory", onecategory);
        }

        [HttpPost("product/{productId}/adding_category")]
        public IActionResult AddCategory(int categoryIdToAdd, int productId)
        {
            var RetrieveProduct = db.Product
                .Include(p => p.Categories)
                .ThenInclude(a => a.Category)
                .FirstOrDefault(p => p.ProductId == productId);

            var RetrieveCategory = db.Categories
                .FirstOrDefault(c => c.CategoryId == categoryIdToAdd);

            RetrieveProduct.Categories.Add(new Associations
            {
                Product = RetrieveProduct,
                Category = RetrieveCategory,
            });

            db.SaveChanges();
            return RedirectToAction("OneProduct", new{productId = productId});
        }

        [HttpPost("category/{categoryId}/adding_product")]
        public IActionResult AddProduct(int productIdToAdd, int categoryId)
        {
            var RetrievedCategory = db.Categories
                .Include(p => p.Products)
                .ThenInclude(a => a.Product)
                .FirstOrDefault(p => p.CategoryId == categoryId);

            var RetrievedProduct = db.Product
                .FirstOrDefault(p => p.ProductId == productIdToAdd);

            RetrievedCategory.Products.Add(new Associations
            {
                Category = RetrievedCategory,
                Product = RetrievedProduct
            });

            db.SaveChanges();
            return RedirectToAction("OneCategory", new { categoryId = categoryId });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
