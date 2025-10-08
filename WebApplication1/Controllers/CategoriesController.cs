using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var categories = context.categories.ToList();
            return View("index", categories);
        }
        public ViewResult Details(int id)
        {
            var category = context.categories.Find(id);
            return View("Details", category);
        }
        public ViewResult Create()
        {
            return View("Create" ,new Category());
        }

        public IActionResult Store(Category request)
        {
            if (ModelState.IsValid)
            {
                context.categories.Add(request);
                context.SaveChanges();
                return RedirectToAction("index");
            }
            return View("Create", request);  
        }
        public RedirectToActionResult Delete(int id)
        {
            var category = context.categories.Find(id);
            context.categories.Remove(category);
            context.SaveChanges(); 
            return RedirectToAction("index");

        }
        public IActionResult Edit(int id)
        {
            var category = context.categories.Find(id);
            if (category == null)
                return NotFound();
            return View(category);
        }

        
        [HttpPost]
        public IActionResult Edit(Category c)
        {
            if (ModelState.IsValid)
            {
                context.categories.Update(c);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c);
        }


    }
}
