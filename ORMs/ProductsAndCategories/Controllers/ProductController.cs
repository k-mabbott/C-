using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsAndCategories.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    private MyContext DB;

    public ProductController(ILogger<ProductController> logger, MyContext context)
    {
        _logger = logger;
        DB = context;
    }
    // ---------------------------------Home/Landing page
    [HttpGet("")]
    public IActionResult Index()
    {
        List<Product> allProducts = DB.Products.ToList();
        ViewBag.allProducts = allProducts;
        return View();
    }
    // ---------------------------------Create new product
    [HttpPost("products/create")]
    public IActionResult CreateProduct(Product newProduct)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }

        DB.Add(newProduct);
        DB.SaveChanges();

        return RedirectToAction("Index");
    }

    // ---------------------------------Create new association
    [HttpPost("productcategories/new/product/{productId}")]
    public IActionResult AddCategory(int categoryId, int productId)
    {

        ProductCategory? existing = DB.ProductCategories.FirstOrDefault(a => a.CategoryId == categoryId && a.ProductId == productId);
        if(existing != null)
        {
            return RedirectToAction("OneProduct", new {productId});
        }
        ProductCategory newConnection = new ProductCategory()
        {
            ProductId = productId,
            CategoryId = categoryId
        };

        DB.ProductCategories.Add(newConnection);
        DB.SaveChanges();

        return RedirectToAction("Index");
    }

    // ---------------------------------Get one product W/ categories
    [HttpGet("products/{productId}")]
    public IActionResult OneProduct(int productId)
    {
        Product? oneProduct = DB.Products.Include(c => c.Categories).ThenInclude(c => c.Category).FirstOrDefault(s => s.ProductId == productId);
        // List<Category> otherCategories = DB.Categories.Include(c => c.Products).ToList();
        List<Category> otherCategories = DB.Categories.Include(p => p.Products).ThenInclude(p => p.Product).Where(e => !e.Products.Any(c => c.ProductId == productId)).ToList();

        ViewBag.categories = otherCategories;
        return View(oneProduct);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    // ---------------------------------Remove asssociation
    [HttpPost("productcategories/remove/product/{productId}")]
    public IActionResult RemoveCategory(int productId, int categoryId)
    {
        ProductCategory? existing = DB.ProductCategories.FirstOrDefault(a => a.CategoryId == categoryId && a.ProductId == productId);
        if(existing != null)
        {
        DB.ProductCategories.Remove(existing);
        }
        DB.SaveChanges();
        return RedirectToAction("OneProduct", new {productId});
    }

}