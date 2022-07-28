using MangaCollectionWeb.Data;
using MangaCollectionWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace MangaCollectionWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;

        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategorList = _db.Categories;
            return View(objCategorList);
        }

        //GET
        public IActionResult Create()
        {
          return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category cat)
        {
            _db.Categories.Add(cat);
            _db.SaveChanges();
            return View();
        }
    }
}
