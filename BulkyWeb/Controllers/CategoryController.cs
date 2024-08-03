using Bulky.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _dbContext;
    
    // dbContext is the context from AddDbContext on Program.cs.
    // it is injected via DI.
    public CategoryController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    // GET
    public IActionResult Index()
    {
        var objCategoryList = _dbContext.Categories.ToList();
        return View();
    }
}