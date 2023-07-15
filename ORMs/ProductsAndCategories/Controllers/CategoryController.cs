using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsAndCategories.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;

    private MyContext DB;

    public CategoryController(ILogger<CategoryController> logger, MyContext context)
    {
        _logger = logger;
        DB = context;
    }
    // ---------------------------------Catergory landing page
    public IActionResult Index()
    {
        List<Category> allCategories = DB.Categories.ToList();
        ViewBag.allCategories = allCategories;
        return View();
    }
    // ---------------------------------Crete new Catergory
    [HttpPost("categories/create")]
    public IActionResult CreateCategory(Category newCategory)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }

        DB.Add(newCategory);
        DB.SaveChanges();

        return RedirectToAction("Index");
    }

    // ---------------------------------Create new association
    [HttpPost("productcategories/new/category/{categoryId}")]
    public IActionResult AddProduct(int categoryId, int productId)
    {
        int catId = categoryId;
        int prodId = productId;

        ProductCategory? existing = DB.ProductCategories.FirstOrDefault(a => a.CategoryId == catId && a.ProductId == prodId);
        if (existing != null)
        {
            return RedirectToAction("OneCategory", new { categoryId });
        }
        ProductCategory newConnection = new ProductCategory()
        {
            ProductId = prodId,
            CategoryId = catId
        };

        DB.Add(newConnection);
        DB.SaveChanges();

        return RedirectToAction("OneCategory", new {categoryId});
    }

    // ---------------------------------Get one Category W/ categories
    [HttpGet("categories/{categoryId}")]
    public IActionResult OneCategory(int categoryId)
    {
        Category? oneCategory = DB.Categories.Include(p => p.Products).ThenInclude(d => d.Product).FirstOrDefault(s => s.CategoryId == categoryId);
        List<Product> otherProducts = DB.Products.Include(c => c.Categories).ThenInclude(c => c.Category).Where(s => !s.Categories.Any(p => p.CategoryId == categoryId)).ToList();
        ViewBag.products = otherProducts;
        return View(oneCategory);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

        // ---------------------------------Remove asssociation
    [HttpPost("productcategories/remove/category/{categoryId}")]
    public IActionResult RemoveProduct(int categoryId, int productId )
    {
        ProductCategory? existing = DB.ProductCategories.FirstOrDefault(a => a.CategoryId == categoryId && a.ProductId == productId);
        if(existing != null)
        {
        DB.ProductCategories.Remove(existing);
        }
        DB.SaveChanges();
        return RedirectToAction("OneCategory", new {categoryId});
    }


}