using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using EXE201.Models;

namespace EXE201.Controllers.Products
{
    public class ProductController : Controller
    {
        private readonly IMongoCollection<Product> _product;
        public ProductController()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("MayViet");
            _product = database.GetCollection<Product>("Products");
        }

        public IActionResult Index()
        {
            var product = _product.Find(p => p.Status == true).ToList();

            return View(product);
        }
    }
}
